using CE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
}
}
