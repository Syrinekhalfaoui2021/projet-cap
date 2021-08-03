using Microsoft.AspNetCore.Identity;

namespace CAP.Data
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }

}