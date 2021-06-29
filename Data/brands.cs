using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CE.Data
{
    [Table(name: "AspNetBrand")]

    public class brands
    {
        [Key]
        [DisplayName("Code")]
        public double codebrand { get; set; }
        [DisplayName("Brand")]
        public string Namebrand { get; set; }
        public string Color { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ICollection<models> Models { get; set; }
        public virtual ICollection<SammaryReport> SammaryReports { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}
