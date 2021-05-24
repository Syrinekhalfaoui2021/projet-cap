using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CE.ViewModels
{
    public class UsersViewModel
    {
           
        public IEnumerable<Models.UserViewModel> UserModels { get; set; }
        public string SelectedUser { get; set; }
    }
}

