using CAP.Data;
using System.Collections.Generic;

namespace CAP.ViewModels
{
    public class ModelViewModel
    {
        public IEnumerable<models> Models { get; set; }
        public string SelectedModel { get; set; }
    }
}
