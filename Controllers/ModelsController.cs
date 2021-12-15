﻿using CAP.Data;
using CAP.Services;
using CAP.Services.Interfaces;
using CAP.ViewModels;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CAP.Controllers
{
    public class ModelsController : Controller, IModelsController
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IDataAccessService _dataAccessService;
        private readonly IDataFlowService dataFlowService;
        private readonly ILogger<ModelsController> _logger;

        public ModelsController(
                UserManager<ApplicationUser> userManager,
                RoleManager<ApplicationRole> roleManager,
                IDataAccessService dataAccessService,
                IDataFlowService dataFlowService,
                ILogger<ModelsController> logger,
                ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dataAccessService = dataAccessService;
            this.dataFlowService = dataFlowService;
            _logger = logger;
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        // GET: Models
        public async Task<IActionResult> IndexModels()
        {
            var vm = new ModelViewModel
            {
                Models = await _context.Modelss
                .Include(x => x.Brand)
                .ToListAsync(),
                SelectedModel = ""
            };
            return View(vm);
           
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id)
        {
            ViewBag.Brands = await GetBrandsSelectList();

            if (id == 0)
                return View(new models());
            else
                return View(_context.Modelss.Find(id));
        }
        // POST: Models /Create

        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModels")]
        public async Task<IActionResult> AddOrEditModelsAsync(ModelEnum SelectedModel)
        {
            ViewBag.Brands = await GetBrandsSelectList();

            var viewName = "AddOrEditModel";
            return View(viewName + SelectedModel.ToString());


        }

        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModelsAC")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("code,Name,TypeAC,Puissance,ClassasNumber,Availibility,Price,Brandcodebrand")] AC ac)

        {

          
                ViewBag.Brands = await GetBrandsSelectList();
            switch (ac.ClassasNumber)
            {
                case 0:
                    ac.Classac = ClassAC.Basic;
                    break;
                case 1:
                    ac.Classac = ClassAC.Premuim;
                    break;
            }
                    _context.Add(ac);
               
                 _context.SaveChanges();
                return RedirectToAction(nameof(IndexModels));
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModelsDW")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("code,Name,Encastrable,Color,Price,Display,Numberofcovers,Price,Promgramme,Availibility,Energeticefficiency,Brandcodebrand")] DW dw)

        {
            ViewBag.Brands = await GetBrandsSelectList();

            _context.Add(dw);

            _context.SaveChanges();
            return RedirectToAction(nameof(IndexModels));
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModelREF")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("code,Name,Type2,Color,Segment,Capacity,Energy,Class,Technology,Frost,Display,Waterdispenser,TypeREF,Segment2,Availibility,Price,Brandcodebrand")] REF rEF)

        {
            ViewBag.Brands = await GetBrandsSelectList();

            _context.Add(rEF);
            _context.SaveChanges();
            return RedirectToAction(nameof(IndexModels));
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModelWM")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("code,Name,TypeWM2,Color,SizeCategory,segementWM,Capacity,Drying,DryerCapacity,Technology,Class,Motor,TypeWM,Availibility,Price,Brandcodebrand")] WM wM)

        {
            ViewBag.Brands = await GetBrandsSelectList();

            _context.Add(wM);
            _context.SaveChanges();
            return RedirectToAction(nameof(IndexModels));
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AddOrEditModelTV")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("code,Name,Class,TypeTV,Size,SizeCategory,Resolution,Form,SmartTV,SegmentTV,Availibility,Price")] TV tV)

        {
            ViewBag.Brands = await GetBrandsSelectList();

            _context.Add(tV);
            _context.SaveChanges();
            return RedirectToAction(nameof(IndexModels));
        }

        [Authorize(Roles = "Admin")]
        // GET: Models/Delete/5
        public async Task<IActionResult> DeleteModels(int? id)
        {
            var models = await _context.Modelss.FindAsync(id);
            _context.Modelss.Remove(models);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexModels));
        }
        // import  and exprt data  Models 
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ActionName("DownloaExcelDocumentmodel")]
        public async Task<IActionResult> DownloadExcelDocumentModel()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "datamodel.xlsx";

            try
            {
                var datamodel = await _context.Modelss
                    .Include(x => x.User)
                    .ToListAsync();
                var xl = dataFlowService.Export(datamodel);

                using var stream = new MemoryStream();
                xl.SaveAs(stream);

                var content = stream.ToArray();
                return File(content, contentType, fileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ActionName("ImportExcelDocumentmodel")]
        public IActionResult ImportExcelDocumentmodel([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var datamodel = new List<models>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDatamodel = new models();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        newDatamodel.Code = row.Cell(1).Value.GetHashCode();

                        newDatamodel.CodeBP = row.Cell(2).Value.ToString();
                        newDatamodel.Name = row.Cell(3).Value.ToString();
                        newDatamodel.Brand.Namebrand = row.Cell(4).Value.ToString();
                        // newDatamodel.Type = row.Cell(4).Value.ToString();
                        newDatamodel.Price = row.Cell(5).Value.GetHashCode();
                        datamodel.Add(newDatamodel);
                    }
                }
                _context.Modelss.AddRange(datamodel);
                _context.SaveChanges();
            }
            return RedirectToAction("IndexModels");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ActionName("Searchmodel")]
        public async Task<IActionResult> SearchmodelAsync(string search)

        {

            ViewBag.Users = GetUsersSelectList();
            var datamodel = _context.Modelss.ToList();
            if (!String.IsNullOrEmpty(search))
            {
                datamodel = await _context.Modelss
                    .Where(x =>

                        (x.User != null && x.User.UserName == search) ||
                        x.CodeBP.Contains(search)
                    //x.Brand.Contains(search) ||
                    //  x.Type.Contains(search)
                    ).ToListAsync()
                    .ConfigureAwait(false);
            }
            return View("IndexModels", datamodel);
        }

        [Authorize(Roles = "Admin")]
        private List<SelectListItem> GetUsersSelectList()
        {
            var users = _userManager.GetUsersInRoleAsync("Employee").GetAwaiter().GetResult().ToList()
                .Select(x => $"{x.FirstName} {x.LastName}").ToList();
            var values = from value in users
                         select new SelectListItem
                         {
                             Text = value.ToString(),
                             Value = value.ToString(),
                             Selected = false
                         };
            return values.ToList();

        }

        [Authorize(Roles = "Admin")]
        // GET: sammary reports 
        public async Task<IActionResult> Indexsammaryweekly()
        {
            return View(await _context.sammaryReports
                .Include(x => x.Models)
                .Include(x => x.Outlets)
                .ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddOrEditsammary(int id = 0)
        {
            if (id == 0)
                return View(new SammaryReport());
            else
                return View(_context.sammaryReports.Find(id));
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditsammary(int id, [Bind("Idsammary")] SammaryReport sammaryweekly)
        {
            if (ModelState.IsValid)
            {
                if (sammaryweekly.Idsammary == 0)
                    _context.Add(sammaryweekly);
                else
                    _context.Update(sammaryweekly);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Indexsammaryweekly));
            }
            return View(sammaryweekly);
        }

        [Authorize(Roles = "Admin")]
        // GET: sammaryweekly/Delete/5
        public async Task<IActionResult> Deletesammary(int? id)
        {
            var sammaryweekly = await _context.sammaryReports.FindAsync(id);
            _context.sammaryReports.Remove(sammaryweekly);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Indexsammaryweekly));
        }


        [Authorize(Roles = "Admin")]

        // GET: Brands
        public async Task<IActionResult> IndexBrands()
        {
            return View(await _context.Brands
                .Include(x => x.Models)

                .ToListAsync());
        }

        [Authorize(Roles = "Admin")]


        public async Task<IActionResult> AddOrEditBrandsAsync(int id = 0)
        {
            ViewBag.Brands = await GetBrandsSelectList();

            if (id == 0)
                return View(new brands());
            else
                return View(_context.Brands.Find(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditBrands(int id, [Bind("codebrand,Namebrand,Color")] brands brands)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                    _context.Add(brands);
                else

                    _context.Update(brands);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexBrands));
            }
            return View(brands);
        }

        [Authorize(Roles = "Admin")]
        // GET: Brands/Delete/5
        public async Task<IActionResult> DeleteBrands(int? id)
        {
            var brands = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(brands);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexBrands));
        }
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "Manager")]
        // import  and export  recherche data  Brands 
        [HttpPost]
        [ActionName("DownloadExcelDocumentvisitmonthly")]
        public async Task<IActionResult> DownloadExcelDocumentBrands()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "dataBrands.xlsx";

            try
            {
                var dataBrands = await _context.Brands

                    .ToListAsync();
                var xls = dataFlowService.ExportBrands(dataBrands);

                using var stream = new MemoryStream();
                xls.SaveAs(stream);

                var content = stream.ToArray();
                return File(content, contentType, fileName);
            }
            catch (Exception ex)

            {
                throw ex;
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ActionName("ImportExcelDocumentBrands")]
        public IActionResult ImportExcelDocumentBrands([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var dataBrands = new List<brands>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDataBrands = new brands();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        newDataBrands.Namebrand = row.Cell(3).Value.ToString();
                        newDataBrands.Color = row.Cell(4).Value.ToString();
                        //newDatamodel.Type = row.Cell(4).Value.ToString();
                        // newDatamodel.Price = row.Cell(5).Value.ToString();
                        dataBrands.Add(newDataBrands);
                    }
                }
                _context.Brands.AddRange(dataBrands);
                _context.SaveChanges();
            }
            return RedirectToAction("IndexBrands");

        }

        public IActionResult AddOrEditModels()
        {
            throw new NotImplementedException();
        }
        private async Task<List<SelectListItem>> GetBrandsSelectList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return _context.Brands.ToList()
                        .Select(x => new SelectListItem
                        {
                            Text = x.Namebrand,
                            Value = x.codebrand.ToString(),
                            Selected = false
                        })
                        .ToList();
            }
            return _context.Brands.ToList()


                .Where(x => x.UserId == user.Id)
                       .Select(x => new SelectListItem
                        {
                            Text = x.Namebrand,
                            Value = x.codebrand.ToString(),
                            Selected = false
                        })
                        .ToList();
        }

        IActionResult IModelsController.AddOrEditBrandsAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.AddOrEditBrands(int id, brands brands)
        {
            throw new NotImplementedException();
        }

        IActionResult IModelsController.AddOrEditModels()
        {
            throw new NotImplementedException();
        }

        IActionResult IModelsController.AddOrEditModels(ModelEnum SelectedModel)
        {
            throw new NotImplementedException();
        }

        IActionResult IModelsController.AddOrEditsammary(int id)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.AddOrEditsammary(int id, SammaryReport sammaryweekly)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.DeleteBrands(int? id)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.DeleteModels(int? id)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.Deletesammary(int? id)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.DownloadExcelDocumentBrands()
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.DownloadExcelDocumentModel()
        {
            throw new NotImplementedException();
        }

        IActionResult IModelsController.ImportExcelDocumentBrands(IFormFile input)
        {
            throw new NotImplementedException();
        }

        IActionResult IModelsController.ImportExcelDocumentmodel(IFormFile input)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.IndexBrands()
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.IndexModels()                 
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.Indexsammaryweekly()
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IModelsController.SearchmodelAsync(string search)
        {
            throw new NotImplementedException();
        }
    }
}
