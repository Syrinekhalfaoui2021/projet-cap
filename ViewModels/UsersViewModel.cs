using System.Collections.Generic;

namespace CE.ViewModels
{
    public class UsersViewModel
    {

        public IEnumerable<Models.UserViewModel> UserModels { get; set; }
        public string SelectedUser { get; set; }
    }
}

