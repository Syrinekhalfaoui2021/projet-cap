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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }

       
     

        [DisplayName("Entry time")]


        public DateTime Entrytime { get; set; }
        public Visits()
        {
            Entrytime = DateTime.Now;
            Date = DateTime.Now;
            Exittime = DateTime.Now;

        }
        [DisplayName("Exit time")]

        public DateTime Exittime { get; set; }
        [DisplayName("Remark")]

        [Column(TypeName = "nvarchar(1000)")]
        public string Remark { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Article")]

        public string Article { get; set; }
      
        [DisplayName("Activity")]

        public string Activity { get; set; }
       
        public int Presence { get; set; }
        [DisplayName("Sales(Q)")]
        public string SalesQ { get; set; }
        [DisplayName("Sales(A)")]

        public string SalesA { get; set; }
    [ForeignKey("Outlets")]
        public int? IdOutlet { get; set; }
        [ForeignKey("models")]
        public int? Code { get; set; }
        public  Outlets Outlets { get; set; }
        public brands Brand { get; set; }
        public models Models { get; set; }
        public virtual ApplicationUser User { get; set; }

            public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(this.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
      
    }
}
