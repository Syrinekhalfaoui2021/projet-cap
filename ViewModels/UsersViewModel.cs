using System.Collections.Generic;

namespace CAP.ViewModels
{
    public class UsersViewModel
    {

        public IEnumerable<Models.UserViewModel> UserModels { get; set; }
        public string SelectedUser { get; set; }
    }
}

