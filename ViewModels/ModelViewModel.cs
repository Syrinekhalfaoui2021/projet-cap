using CE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CE.ViewModels
{
    public class ModelViewModel
    {
        public IEnumerable<models> Models { get; set; }
        public string SelectedModel { get; set; }
    }
}
