using CAP.Data;
using CAP.Services;
using CAP.Services.Interfaces;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace CAP.Controllers
{
    public class VisitsController : Controller
    {



        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IDataAccessService _dataAccessService;
        private readonly IDataFlowService dataFlowService;
        private readonly ILogger<VisitsController> _logger;


        public VisitsController(
                UserManager<ApplicationUser> userManager,
                RoleManager<ApplicationRole> roleManager,
                IDataAccessService dataAccessService,
                IDataFlowService dataFlowService,
                ILogger<VisitsController> logger,
                ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dataAccessService = dataAccessService;
            this.dataFlowService = dataFlowService;
            _logger = logger;
            _context = context;
        }



        // GET: Visits
        public async Task<IActionResult> Index()
        {


            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Users = GetUsersSelectList();
            var result = await _context.Visits
                .Where(x => x.User.Id == user.Id)
                .ToListAsync();
            return View(await _context.Visits

                .Where(x => x.User.Id == user.Id)
                .Include(x => x.Models)
                .Include(x => x.Outlets)
                .ToListAsync());

        }






        private List<SelectListItem> GetUsersSelectList()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult();
            if (_userManager.IsInRoleAsync(user, "Admin").GetAwaiter().GetResult())
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
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = user.UserName,
                    Value = user.UserName,
                    Selected = true
                }
            };

        }


        private async Task<List<SelectListItem>> GetOutletsSelectList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return _context.Outletss.ToList()
                        .Select(x => new SelectListItem
                        {
                            Text = x.POSName,
                            Value = x.IdOutlet.ToString(),
                            Selected = false
                        })
                        .ToList();
            }
            return _context.Outletss.ToList()
                        .Where(x => x.UserId == user.Id)
                        .Select(x => new SelectListItem
                        {
                            Text = x.POSName,
                            Value = x.IdOutlet.ToString(),
                            Selected = false
                        })
                        .ToList();
        }

        public async Task<IActionResult> AddOrEdite(int id = 0)
        {
            ViewBag.Outlets = await GetOutletsSelectList();
            if (id == 0)
                return View(new Visits());
            else
                return View(_context.Visits.Find(id));
        }
        // POST: Visits /Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdite(int id, [Bind("IdVisit,Date,Entrytime,Exittime,Remark,IdOutlet")] Visits visits)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Outlets = await GetOutletsSelectList();
                if (id == 0)
                {

                    var user = await _userManager.FindByNameAsync(User.Identity.Name);
                    visits.User = user;

                    _context.Add(visits);
                }
                else
                {
                    visits.IdVisit = id;
                    _context.Update(visits);


                }

                var x = _context.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            return View(visits);
        }


        // GET: visits/Delete/5
        public async Task<IActionResult> Deletee(int? id)
        {
            var visits = await _context.Visits.FindAsync(id);
            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }






        // import  and exprt data  visits daily 
        [HttpPost]
        [ActionName("DownloadExcelDocumentvisit")]
        public async Task<IActionResult> DownloadExcelDocumentvisit()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "datavisit.xlsx";

            try
            {
                var datavisit = await _context.Visits
                    .Include(x => x.User)
                    .Include(x => x.Outlets)
                    .Include(x => x.Models)
                    .Include(x => x.Brand)
                    .ToListAsync();
                var xls = dataFlowService.Exportvisit(datavisit);

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

        [HttpPost]
        [ActionName("ImportExcelDocumentvisit")]
        public IActionResult ImportExcelDocumentvisit([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var datavisit = new List<Visits>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDatavisit = new Visits();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {

                        DateTime.TryParse(row.Cell(2).Value.ToString(), out DateTime date);
                        if (date != null)
                        {
                            newDatavisit.Date = date;
                        }
                        newDatavisit.Outlets.POSName = row.Cell(3).Value.ToString();
                        newDatavisit.Models.ModelName= row.Cell(4).Value.ToString();
                        newDatavisit.Brand.Namebrand = row.Cell(5).Value.ToString();
                        newDatavisit.Presence = row.Cell(6).Value.ToString();
                        newDatavisit.SalesQ = row.Cell(7).Value.ToString();
                        newDatavisit.SalesA = row.Cell(8).Value.ToString();

                    }
                }
                _context.Visits.AddRange(datavisit);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //recherche visit daily
        [HttpPost]
        [ActionName("Searchvisit")]
        public IActionResult Searchvisit(string searchvisit, DateTime startDate, DateTime endDate, string Users)
        {
            ViewBag.Users = GetUsersSelectList();
            var datavisit = _context.Visits.ToList();
            if (!String.IsNullOrEmpty(searchvisit) || (startDate != null && endDate != null))
            {
                var names = Users.Split(" ");
                datavisit = _context.Visits
                    .ToList()
                    .Where(x =>
                        (x.User != null && x.User.UserName == searchvisit) ||

                        (x.Date >= startDate && x.Date <= endDate) ||
                        (x.User != null && names.Length > 2 &&
                            String.Equals(x.User.FirstName, names[0], StringComparison.OrdinalIgnoreCase) &&
                            String.Equals(x.User.FirstName, names[1], StringComparison.OrdinalIgnoreCase))
                    ).ToList();
            }

            return View("Index", datavisit);
        }


        public async Task<IActionResult> DailyVisitsModel()

        {

            return View(await _context.Modelss


                .Include(x => x.Visitss)
                .Include(x => x.Brand)
                .Include(x => x.Outlets)

                .ToListAsync()); ;
        }





    }
}