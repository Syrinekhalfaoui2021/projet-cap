using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Activity")]

        public string Activity { get; set; }

        [ForeignKey("Outlets")]
        public int? IdOutlet { get; set; }
        public Outlets Outlets { get; set; }
        public ICollection <brands> Brand { get; set; }
        public ICollection<models> Models { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
