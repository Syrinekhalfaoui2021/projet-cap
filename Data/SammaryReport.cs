using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CE.Data
{
    [Table(name: "AspNetsammaryweekly")]

    public class SammaryReport
    {

        [Key]
        public int Idsammary { get; set; }


        public virtual ApplicationUser User { get; set; }
        public virtual models Models { get; set; }
        public virtual Outlets Outlets{ get; set; }
        public virtual brands Brands { get; set; }
        public virtual TV Tv { get; set; }
        public virtual WM Wm { get; set; }
        public virtual REF REF { get; set; }
        public virtual AC AC { get; set; }


     }
    public class SammaryReportWeekly : SammaryReport
    {
        public int IdSammaryReportWeekly { get; set; }

    }
    public class SammaryReportMonthly : SammaryReport
    {

        public int IdSammaryReportMonthly { get; set; }




    }
}
