using CE.Data;
using System.Collections.Generic;

namespace CE.ViewModels
{
    public class ModelViewModel
    {
        public IEnumerable<models> Models { get; set; }
        public string SelectedModel { get; set; }
    }
}
