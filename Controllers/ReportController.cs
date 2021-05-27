using CE.Data;
using CE.Services;
using CE.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CE.Controllers
{
    public class ReportController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IDataAccessService _dataAccessService;
        private readonly IDataFlowService dataFlowService;
        private readonly ILogger<ReportController> _logger;

        public ReportController(
            UserManager<ApplicationUser> userManager,
                RoleManager<ApplicationRole> roleManager,
                IDataAccessService dataAccessService,
                IDataFlowService dataFlowService,
                ILogger<ReportController> logger,
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
        public IActionResult Reportweekly()
        {

            return View("Views/Report/Reportweekly.cshtml");

        }

        [Authorize(Roles = "Admin")]

        public IActionResult Reportmonthly()
        {

            return View("Views/Report/Reportmonthly.cshtml");

        }
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> TVModelW()
        {

            return View(await _context.sammaryReportWeeklies
                              .Include(x => x.Models)
                              .Include(x => x.Outlets)
                              .Include(x => x.Tv)
                              .Include(x => x.Brands)
                              .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> REFModelW()
        {

            return View(await _context.sammaryReportWeeklies
                                          .Include(x => x.Models)
                                          .Include(x => x.Outlets)
                                          .Include(x => x.REF)
                                          .Include(x => x.Brands)
                                          .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ACModelW()
        {


            return View(await _context.sammaryReportWeeklies
                                          .Include(x => x.Models)
                                          .Include(x => x.Outlets)
                                          .Include(x => x.AC)
                                          .Include(x => x.Brands)
                                          .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> WMModelW()
        {
            return View(await _context.sammaryReportWeeklies
                                    .Include(x => x.Models)
                                    .Include(x => x.Outlets)
                                    .Include(x => x.Wm)
                                    .Include(x => x.Brands)
                                    .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> TVModelsM()
        {

            return View(await _context.sammaryReportMonthlies
                                             .Include(x => x.Models)
                                             .Include(x => x.Outlets)
                                             .Include(x => x.Tv)
                                             .Include(x => x.Brands)
                                             .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> REFModelM()
        {

            return View(await _context.sammaryReportMonthlies
                                                                  .Include(x => x.Models)
                                                                  .Include(x => x.Outlets)
                                                                  .Include(x => x.REF)
                                                                  .Include(x => x.Brands)
                                                                  .ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ACModelM()
        {
            return View(await _context.sammaryReportMonthlies
                                                                  .Include(x => x.Models)
                                                                  .Include(x => x.Outlets)
                                                                  .Include(x => x.AC)
                                                                  .Include(x => x.Brands)
                                                                  .ToListAsync());



        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> WMModelM()
        {
            return View(await _context.sammaryReportMonthlies
                                                                  .Include(x => x.Models)
                                                                  .Include(x => x.Outlets)
                                                                  .Include(x => x.Wm)
                                                                  .Include(x => x.Brands)
                                                                  .ToListAsync());

        }
    }
}
