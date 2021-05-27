using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CE.Data
{
    [Table(name: "AspNetOutlet")]
    public class Outlets
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [DisplayName("Code")]
        public int IdOutlet { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Name outlet")]
        public string NameOutlet { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        [DisplayName("Key dealer")]
        public string Keydealer { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Compte { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Type { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Class { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Activity { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Zone { get; set; }
        [Column(TypeName = "nvarchar(250)")]


        public string State { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string City { get; set; }

        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(10)")]

        public string Longitude { get; set; }

        public string Latitude { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Address { get; set; }
        [DisplayName("Outlet type")]
        public string Outletstype { get; set; }
        public string District { get; set; }
        public string Channel { get; set; }
        public string Retailer { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }


        public virtual Visits Visitss { get; set; }
        public virtual Visitsweekly Visitssweekly { get; set; }
        public virtual Visitsmonthly Visitssmonthly { get; set; }

        public virtual ApplicationUser User { get; set; }



    }
}

