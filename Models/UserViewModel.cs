using CAP.Data;
using System.Collections.Generic;


namespace CAP.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }


        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        public virtual ICollection<Outlets> Outlets { get; set; }
        public RoleViewModel[] Roles { get; set; }
    }
}