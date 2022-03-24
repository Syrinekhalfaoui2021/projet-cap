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
        public async Task<IActionResult> Indexe()
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
                            Text = x.Account,
                            Value = x.IdOutlet.ToString(),
                            Selected = false
                        })
                        .ToList();
            }
            return _context.Outletss.ToList()
                        .Where(x => x.UserId == user.Id)
                        .Select(x => new SelectListItem
                        {
                            Text = x.Account,
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


                return RedirectToAction(nameof(Indexe));
            }
            return View(visits);
        }


        // GET: visits/Delete/5
        public async Task<IActionResult> Deletee(int? id)
        {
            var visits = await _context.Visits.FindAsync(id);
            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Indexe));
        }
        // GET: Visitsweekly 
        public async Task<IActionResult> Indexweekly()
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Users = GetUsersSelectList();
            var result = await _context.Visitssweekly
                .Where(x => x.User.Id == user.Id)
                .ToListAsync();
            return View(await _context.Visitssweekly
                .Where(x => x.User.Id == user.Id)
                .Include(x => x.Models)
                .Include(x => x.Outlets)
                .ToListAsync());
        }


        public async Task<IActionResult> AddOrEditweeklyAsync(int id = 0)
        {
            ViewBag.Outlets = await GetOutletsSelectList();

            if (id == 0)
                return View(new Visitsweekly());
            else
                return View(_context.Visitssweekly.Find(id));
        }
        // POST: Visitsweekly /Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditweekly(int id, [Bind("IdVisit,Date,Entrytime,Exittime,Remark,IdOutlet")] Visitsweekly visitsweekly)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Outlets = await GetOutletsSelectList();

                if (id == 0)
                {

                    var user = await _userManager.FindByNameAsync(User.Identity.Name);
                    visitsweekly.User = user;
                    _context.Add(visitsweekly);
                }
                else

                    _context.Update(visitsweekly);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Indexweekly));
            }
            return View(visitsweekly);
        }


        // GET: Visitsweekly/Delete/5

        public async Task<IActionResult> Deleteweekly(int? id)
        {
            var visitsweekly = await _context.Visitssweekly.FindAsync(id);
            _context.Visitssweekly.Remove(visitsweekly);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Indexweekly));
        }
        // GET: VisitsMonthly
        public async Task<IActionResult> Indexmonthly()
        {


            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Users = GetUsersSelectList();
            var result = await _context.Visitssmonthly
                .Where(x => x.User.Id == user.Id)
                .ToListAsync();
            return View(await _context.Visitssmonthly
                .Where(x => x.User.Id == user.Id)
                .Include(x => x.Models)
                .Include(x => x.Outlet)
                .ToListAsync());
        }



        public async Task<IActionResult> AddOrEditmonthlyAsync(int id = 0)

        {
            ViewBag.Outlets = await GetOutletsSelectList();

            if (id == 0)
                return View(new Visitsmonthly());
            else
                return View(_context.Visitssmonthly.Find(id));
        }
        // POST: Visitsweekly /Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditmonthly(int id, [Bind("IdVisit,Date,Entrytime,Exittime,Remark,IdOutlet")] Visitsmonthly visitsmonthly)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);
                    visitsmonthly.User = user;
                    _context.Add(visitsmonthly);
                }
                else
                   

                _context.Update(visitsmonthly);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Indexmonthly));
            }
            return View(visitsmonthly);
        }


        // GET: Visitsweekly/Delete/5

        public async Task<IActionResult> Deletemonthly(int? id)
        {
            var visitsmonthly = await _context.Visitssmonthly.FindAsync(id);
            _context.Visitssmonthly.Remove(visitsmonthly);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Indexmonthly));

        }

        // import  and exprt data  visits daily 
        [HttpPost]
        [ActionName("DownloadExcelDocumentvisitdaily")]
        public async Task<IActionResult> DownloadExcelDocumentvisitdaily()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "datavisitdaily.xlsx";

            try
            {
                var datavisitdaily = await _context.Visits
                    .Include(x => x.User)
                    .ToListAsync();
                var xls = dataFlowService.Exportvisitdaily(datavisitdaily);

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
        [ActionName("ImportExcelDocumentvisitdaily")]
        public IActionResult ImportExcelDocumentvisitdaily([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var datavisitdaily = new List<Visits>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDatavisitdaily = new Visits();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        // {firstname} {lastname}
                        var names = row.Cell(2).Value.ToString().Split(" ");
                        var user = _userManager.Users.ToList().FirstOrDefault(x =>
                            String.Equals(x.FirstName, names[0], StringComparison.OrdinalIgnoreCase) ||
                            String.Equals(x.LastName, names[1], StringComparison.OrdinalIgnoreCase)
                        );
                        newDatavisitdaily.User = user;
                        DateTime.TryParse(row.Cell(3).Value.ToString(), out DateTime date);
                        if (date != null)
                        {
                            newDatavisitdaily.Date = date;
                            newDatavisitdaily.Entrytime = date;
                        }
                        newDatavisitdaily.Outlets = _context.Outletss.ToList().FirstOrDefault(x =>
                            String.Equals(x.Account, row.Cell(1).Value.ToString(), StringComparison.OrdinalIgnoreCase)
                        );
                        if (newDatavisitdaily.Outlets == null)
                        {
                            newDatavisit.Outlets.IdOutlet = 0;
                        }
                        datavisitdaily.Add(newDatavisitdaily);
                    }
                }
                _context.Visits.AddRange(datavisitdaily);
                _context.SaveChanges();
            }
            return RedirectToAction("Indexe");
        }
        //recherche visit daily
        [HttpPost]
        [ActionName("Searchvisitdaily")]
        public IActionResult Searchvisitdaily(string searchvisitdaily, DateTime startDate, DateTime endDate, string Users)
        {
            ViewBag.Users = GetUsersSelectList();
            var datavisitdaily = _context.Visits.ToList();
            if (!String.IsNullOrEmpty(searchvisitdaily) || (startDate != null && endDate != null))
            {
                var names = Users.Split(" ");
                datavisitdaily = _context.Visits
                    .ToList()
                    .Where(x =>
                        (x.User != null && x.User.UserName == searchvisitdaily) ||

                        (x.Date >= startDate && x.Date <= endDate) ||
                        (x.User != null && names.Length > 2 &&
                            String.Equals(x.User.FirstName, names[0], StringComparison.OrdinalIgnoreCase) &&
                            String.Equals(x.User.FirstName, names[1], StringComparison.OrdinalIgnoreCase))
                    ).ToList();
            }

            return View("Indexe", datavisitdaily);
        }

        // import  and exprt data  visits weekly  
        [HttpPost]
        [ActionName("DownloadExcelDocumentvisitweekly")]
        public async Task<IActionResult> DownloadExcelDocumentvisitweekly()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "datavisitweekly.xlsx";

            try
            {
                var datavisitweekly = await _context.Visitssweekly
                    .Include(x => x.User)
                    .ToListAsync();
                var xls = dataFlowService.Exportvisitweekly(datavisitweekly);

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
        [ActionName("ImportExcelDocumentvisitweekly")]
        public IActionResult ImportExcelDocumentvisitweekly([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var datavisitweekly = new List<Visitsweekly>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDatavisitweekly = new Visitsweekly();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        // {firstname} {lastname}
                        var names = row.Cell(2).Value.ToString().Split(" ");
                        var user = _userManager.Users.ToList().FirstOrDefault(x =>
                            String.Equals(x.FirstName, names[0], StringComparison.OrdinalIgnoreCase) ||
                            String.Equals(x.LastName, names[1], StringComparison.OrdinalIgnoreCase)
                        );
                        newDatavisitweekly.User = user;
                        DateTime.TryParse(row.Cell(3).Value.ToString(), out DateTime date);
                        if (date != null)
                        {
                            newDatavisitweekly.Date = date;
                            newDatavisitweekly.Entrytime = date;
                        }
                        // newDatavisitweekly.Zone = row.Cell(5).Value.ToString();
                        newDatavisitweekly.Outlets = _context.Outletss.ToList().FirstOrDefault(x =>
                            String.Equals(x.Account, row.Cell(1).Value.ToString(), StringComparison.OrdinalIgnoreCase)
                        );
                        if (newDatavisitweekly.Outlets == null)
                        {
                            newDatavisitweekly.IdOutlet = 0;
                        }
                        datavisitweekly.Add(newDatavisitweekly);
                    }
                }
                _context.Visitssweekly.AddRange(datavisitweekly);
                _context.SaveChanges();
            }
            return RedirectToAction("Indexweekly");
        }

        [HttpPost]
        [ActionName("Searchvisitweekly")]
        public IActionResult Searchvisitweekly(string searchvisitweekly, DateTime startDate, DateTime endDate, string Users)
        {
            ViewBag.Users = GetUsersSelectList();
            var datavisitweekly = _context.Visitssweekly.ToList();
            if (!String.IsNullOrEmpty(searchvisitweekly) || (startDate != null && endDate != null))
            {
                var names = Users.Split(" ");
                datavisitweekly = _context.Visitssweekly
                    .ToList()
                    .Where(x =>
                        (x.User != null && x.User.UserName == searchvisitweekly) ||
                        (!String.IsNullOrEmpty(searchvisitweekly) && x.Remark.Contains(searchvisitweekly)) ||
                        (x.Date >= startDate && x.Date <= endDate) ||
                        (x.User != null && names.Length > 2 &&
                            String.Equals(x.User.FirstName, names[0], StringComparison.OrdinalIgnoreCase) &&
                            String.Equals(x.User.FirstName, names[1], StringComparison.OrdinalIgnoreCase))
                    ).ToList();
            }

            return View("Indexweekly", datavisitweekly);

        }


        // import  and export  recherche data  visits Monthly  
        [HttpPost]
        [ActionName("DownloadExcelDocumentvisitmonthly")]
        public async Task<IActionResult> DownloadExcelDocumentvisitmonthly()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "datavisitmonthly.xlsx";

            try
            {
                var datavisitmonthly = await _context.Visitssmonthly
                    .Include(x => x.User)
                    .ToListAsync();
                var xls = dataFlowService.Exportvisitmonthly(datavisitmonthly);

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
        [ActionName("ImportExcelDocumentvisitmonthly")]
        public IActionResult ImportExcelDocumentvisitmonthly([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var datavisitmonthly = new List<Visitsmonthly>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newDatavisitmonthly = new Visitsmonthly();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        // {firstname} {lastname}
                        var names = row.Cell(2).Value.ToString().Split(" ");
                        var user = _userManager.Users.ToList().FirstOrDefault(x =>
                            String.Equals(x.FirstName, names[0], StringComparison.OrdinalIgnoreCase) ||
                            String.Equals(x.LastName, names[1], StringComparison.OrdinalIgnoreCase)
                        );
                        newDatavisitmonthly.User = user;
                        DateTime.TryParse(row.Cell(3).Value.ToString(), out DateTime date);
                        if (date != null)
                        {
                            newDatavisitmonthly.Date = date;
                            newDatavisitmonthly.Entrytime = date;
                        }
                        //newDatavisitmonthly.Zone = row.Cell(5).Value.ToString();
                        newDatavisitmonthly.Outlet = _context.Outletss.ToList().FirstOrDefault(x =>
                            String.Equals(x.Account, row.Cell(1).Value.ToString(), StringComparison.OrdinalIgnoreCase)
                        );
                        if (newDatavisitmonthly.Outlet == null)
                        {
                            newDatavisitmonthly.IdOutlet = 0;
                        }
                        datavisitmonthly.Add(newDatavisitmonthly);
                    }
                }
                _context.Visitssmonthly.AddRange(datavisitmonthly);
                _context.SaveChanges();
            }
            return RedirectToAction("Indexmonthly");
        }

        [HttpPost]
        [ActionName("Searchvisitmonthly")]
        public IActionResult SearchvisitmonthlyAsync(string searchvisitmonthly, DateTime startDate, DateTime endDate, string Users)
        {
            ViewBag.Users = GetUsersSelectList();
            var datavisitmonthly = _context.Visitssmonthly.ToList();
            if (!String.IsNullOrEmpty(searchvisitmonthly) || (startDate != null && endDate != null))
            {
                var names = Users.Split(" ");
                datavisitmonthly = _context.Visitssmonthly
                    .ToList()
                    .Where(x =>
                        (x.User != null && x.User.UserName == searchvisitmonthly) ||
                        (!String.IsNullOrEmpty(searchvisitmonthly) && x.Remark.Contains(searchvisitmonthly)) ||
                        (x.Date >= startDate && x.Date <= endDate) ||
                        (x.User != null && names.Length > 2 &&
                            String.Equals(x.User.FirstName, names[0], StringComparison.OrdinalIgnoreCase) &&
                            String.Equals(x.User.FirstName, names[1], StringComparison.OrdinalIgnoreCase))
                    ).ToList();
            }

            return View("Indexmonthly", datavisitmonthly);


        }
        public async Task<IActionResult> DailyVisitsModel()

        {
            
            return View(await _context.Modelss
             

                .Include(x => x.Visits)
                .Include(x=>x.Brand)
                .Include(x=>x.Outlets)

                .ToListAsync()); ;
        }
        public async Task<IActionResult> WeeklyVisitsModel()

        {

            return View(await _context.Modelss
                .Include(x => x.Visitsweekly)
                                .Include(x => x.Brand)

                .ToListAsync()); ;
        }
        public async Task<IActionResult> MonthlyVisitsModel()

        {


            return View(await _context.Modelss
                .Include(x => x.Visitsmonthly)
                                .Include(x => x.Brand)

                               .ToListAsync());
        }






    }
}