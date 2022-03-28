using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace CAP.Data
{
    [Table(name: "AspNetVisit")]

    public class Visits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Code")]

        public int IdVisit { get; set; }
        [DisplayName("Date")]

        public DateTime Date { get; set; }




        public Visits()
        {
          
            Date = DateTime.Now;
          

        }


        public string Remark { get; set; }
        public string Presence { get; set; }
        [DisplayName("Sales(Q)")]
        public string SalesQ { get; set; }
        [DisplayName("Sales(Q)")]

        public string SalesA { get; set; }

        [DisplayName("Article")]

        public string Article { get; set; }
        [DisplayName("Activity")]

        public string Activity { get; set; }

        [ForeignKey("Outlets")]
        public int? IdOutlet { get; set; }
        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public  virtual models Models { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(this.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        [ForeignKey("brands")]
        public double? Brandcodebrand { get; set; }
        [ForeignKey("models")]
        public int? Code { get; set; }
    }
}
