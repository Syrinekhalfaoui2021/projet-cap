using CE.Data;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public ImportController(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager
            )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> ImportAsync()
        {
            var workbook = new XLWorkbook(@"C:\Users\syrine-khalfaoui\Desktop\Users.xlsx");
            var ws1 = workbook.Worksheet(1);

            var adminRole = await roleManager.FindByNameAsync("Admin");
            var employeeRole = await roleManager.FindByNameAsync("Employee");
            var admins = new List<string> { "syrine@cap.tn", "wissal@capesolution.tn" };
            foreach (IXLRow row in ws1.Rows())
            {
                var newUser = new ApplicationUser();
                newUser.FirstName = row.Cell(1).Value.ToString();
                newUser.LastName = row.Cell(2).Value.ToString();
                newUser.Email = row.Cell(3).Value.ToString();
                newUser.UserName = row.Cell(3).Value.ToString();
                var userCreated = await userManager.CreateAsync(newUser, "123456");
                if (userCreated.Succeeded)
                {
                    var roleName = row.Cell(4).Value.ToString();
                    if (roleName == "Field Officer")
                    {
                        await userManager.AddToRoleAsync(newUser, employeeRole.Name);
                    }
                    else
                    {
                        if (roleName == "Admin" && admins.Contains(newUser.Email))
                        {
                            await userManager.AddToRoleAsync(newUser, adminRole.Name);
                        }
                        else
                        {
                            await userManager.AddToRoleAsync(newUser, employeeRole.Name);
                        }
                    }
                }
            }
            return Ok();
        }
    }
}
