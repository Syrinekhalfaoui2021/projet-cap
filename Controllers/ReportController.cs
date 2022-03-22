using CAP.Data;
using CAP.Services;
using CAP.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CAP.Controllers
{
    public class ReportController : Controller
    {

        private readonly ApplicationDbContext _context;
     
        public ReportController(
        
                ApplicationDbContext context)
        {
         
            _context = context;
        }
 
    }
}
