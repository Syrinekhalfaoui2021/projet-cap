using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CE.Data
{
    [Table(name: "AspNetVisitweekly")]
    public class Visitsweekly
    {
        public Visitsweekly()
        {
            Date = DateTime.Now;
            Entrytime = DateTime.Now;


         }
        [Key]
        [DisplayName("Code")]
        public int IdVisit { get; set; }
        [DisplayName("Week")]
        public DateTime Date { get; set; }
        [DisplayName("Entry time")]
        public DateTime Entrytime { get; set; }
        [DisplayName("Exit time")]
        public DateTimeOffset Exittime { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Remark { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Article { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Activity { get; set; }
     


        [ForeignKey("Outlets")]
        public int? IdOutlet { get; set; }
        public Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public virtual models Models { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}

