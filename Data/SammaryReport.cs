using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAP.Data
{
    [Table(name: "AspNetsammaryweekly")]

    public class SammaryReport
    {

        [Key]
        public int Idsammary { get; set; }


        public virtual ApplicationUser User { get; set; }
        public virtual models Models { get; set; }
        public virtual Outlets Outlets { get; set; }
        public virtual brands Brands { get; set; }
       


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
