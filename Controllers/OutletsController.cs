using CAP.Data;
using CAP.Services;
using CAP.Services.Interfaces;
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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CAP.Controllers
{
    public class OutletsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IDataAccessService _dataAccessService;
        private readonly IDataFlowService dataFlowService;
        private readonly ILogger<OutletsController> _logger;

        public OutletsController(
                UserManager<ApplicationUser> userManager,
                RoleManager<ApplicationRole> roleManager,
                IDataAccessService dataAccessService,
                IDataFlowService dataFlowService,
                ILogger<OutletsController> logger,
                ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dataAccessService = dataAccessService;
            this.dataFlowService = dataFlowService;
            _logger = logger;
            _context = context;
        }
        // GET: Outlets
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var data = await _context.Outletss
                .Include(x => x.User)
                .ToListAsync()
                .ConfigureAwait(false);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return View(data);
            }
            data = data.Where(x => x.User.Id == user.Id).ToList();
            return View(data);
        }

        [Authorize(Roles = "Admin,Manager")]

        // POST: Outlets /Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Outlets());
            else
                return View(_context.Outletss.Find(id));
        }

        [Authorize(Roles = "Admin,Manager")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("IdOutlet,NameOutlet,Class,Activity,Zone,State,City,Phone,Longitude,Latitude,Address")] Outlets outlets)
        {
            if (ModelState.IsValid)
            {
                if (outlets.IdOutlet == 0)
                    _context.Add(outlets);
                else
                    _context.Update(outlets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outlets);
        }

        [Authorize(Roles = "Admin,Manager")]

        // GET: outlets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var outlets = await _context.Outletss.FindAsync(id);
            _context.Outletss.Remove(outlets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // import  and exprt data  outlets
        [Authorize(Roles = "Admin,Manager")]

        [HttpPost]
        [ActionName("DownloadExcelDocument")]
        public async Task<IActionResult> DownloadExcelDocument()
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "data.xlsx";

            try
            {
                var data = await _context.Outletss
                    .Include(x => x.User)
                    .ToListAsync();
                var xl = dataFlowService.Export(data);

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

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        [ActionName("ImportExcelDocument")]
        public IActionResult ImportExcelDocument([FromForm(Name = "file")] IFormFile input)
        {
            using (XLWorkbook workBook = new XLWorkbook(input.OpenReadStream()))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);
                bool firstRow = true;
                var data = new List<Outlets>();

                foreach (IXLRow row in workSheet.Rows())
                {
                    var newData = new Outlets();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        newData.NameOutlet = row.Cell(2).Value.ToString();
                        // var user = await _userManager.FindByNameAsync(row.Cell(3).Value.ToString());
                        var names = row.Cell(3).Value.ToString().Split(' ');
                        if (names.Length == 2)
                        {
                            var user = _userManager.Users.ToList().FirstOrDefault(x =>
                                String.Equals(x.FirstName, names[0], StringComparison.OrdinalIgnoreCase) ||
                                String.Equals(x.LastName, names[1], StringComparison.OrdinalIgnoreCase)
                            );
                            newData.User = user;
                        }
                        newData.Zone = row.Cell(4).Value.ToString();
                        newData.City = row.Cell(5).Value.ToString();
                        newData.Delegation = row.Cell(6).Value.ToString();
                        newData.District = row.Cell(7).Value.ToString();
                        newData.Channel = row.Cell(8).Value.ToString();
                        newData.Outletstype = row.Cell(9).Value.ToString();
                        newData.Class = row.Cell(10).Value.ToString();
                        newData.Keydealer = row.Cell(11).Value.ToString();


                        data.Add(newData);
                    }
                }
                _context.Outletss.AddRange(data);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ActionName("Search")]
        public async Task<IActionResult> SearchAsync(string search)

        {

            ViewBag.Users = GetUsersSelectList();
            var data = _context.Outletss.ToList();
            if (!String.IsNullOrEmpty(search))
            {
                data = await _context.Outletss
                    .Where(x =>
                        x.NameOutlet.Contains(search) ||
                        (x.User != null && x.User.UserName == search) ||
                        x.Zone.Contains(search) ||
                        x.Delegation.Contains(search) ||
                        x.City.Contains(search)
                    ).ToListAsync()
                    .ConfigureAwait(false);
            }
            return View("Index", data);
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
    }
}

namespace CAP
{
    public class currentuser
    {
    }
}