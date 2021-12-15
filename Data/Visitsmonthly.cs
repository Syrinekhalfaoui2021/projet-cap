using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAP.Data

{
    [Table(name: "AspNetVisitmonthly")]
    public class Visitsmonthly
    {
        public Visitsmonthly()
        {
            Date = DateTime.Now;
            Entrytime = DateTime.Now;
        }
        [Key]
        [DisplayName("Code")]
        public int IdVisit { get; set; }
        [DisplayName("Month")]
        public DateTime Date { get; set; }
        public DateTime Entrytime { get; set; }
        public DateTime Exittime { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Remark { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Article { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Activity { get; set; }


        [ForeignKey("Outlet")]
        public int? IdOutlet { get; set; }
        public Outlets Outlet { get; set; }
        public ICollection<brands> Brand { get; set; }
        public ICollection<models> Models { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
