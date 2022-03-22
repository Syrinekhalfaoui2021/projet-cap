using CAP.Data;
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
    public class ModelsController : Controller
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
           
            {
                return View(await _context.Modelss
                .Include(x => x.Brand)
                .ToListAsync());
               
            }
           
        }
    


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddOrEditModelsAsync(int id=0)
        {
            ViewBag.Brands = await GetBrandsSelectList();

            if (id == 0)
                return View(new models());
            else
                return View(_context.Modelss.Find(id));
        }

       

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> AddOrEditModelsAsync(int id, [Bind("Code,ModelName,Availibility,Price,MarketShare,ShelfShare,Stock,Weeklysail,Category,ProductType,SizeCapacity,REFCapa,DryerCapa,RPM,Segment,Resolution,SMART,Programs,Frosttype,Type,EnergyClass,Dimension,OutterDisplay,WaterDispenser")] models models)
        {
            ViewBag.Brands = await GetBrandsSelectList();

            if (ModelState.IsValid)
            {
                if (id == 0)
                    _context.Add(models);
                else

                    _context.Update(models);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexModels));
            }
            return View(models);
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

                       // newDatamodel.CodeBP = row.Cell(2).Value.ToString();
                        //newDatamodel.Name = row.Cell(3).Value.ToString();
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
                        x.ModelName.Contains(search)
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
                       // newDataBrands.codebrand = row.Cell(2).Value.ToString();

                        newDataBrands.Namebrand = row.Cell(2).Value.ToString();
                        newDataBrands.Color = row.Cell(3).Value.ToString();
                       
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

    }
}
