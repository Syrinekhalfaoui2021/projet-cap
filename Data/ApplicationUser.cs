using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CE.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {




        }

        public ApplicationUser(string userName) : base(userName)
        {




        }



        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Outlets> Outlets { get; set; }
        public virtual ICollection<models> Models { get; set; }
        public virtual ICollection<brands> Brands { get; set; }

    }
}
