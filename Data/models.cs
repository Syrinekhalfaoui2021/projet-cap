using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAP.Data
{
    [Table(name: "AspNetModels")]
    public class models
    {
        [Key]
        [DisplayName("Code")]
        public int Code { get; set; }
        [Column(TypeName = "nvarchar(250)")]
    
        [DisplayName("Model Name")]
        public string ModelName { get; set; }
        [DisplayName("AV")]
        public string Availibility { get; set; }

        public double Price { get; set; }
        [DisplayName("Market Share")]
        public string MarketShare { get; set; }
        [DisplayName("Shelf Share")]
        public string ShelfShare { get; set; }
        public string Stock { get; set; }

        [DisplayName("W/S")]
        public string Weeklysail { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }   
        [DisplayName("Size/Capacity")]
        public string SizeCapacity { get; set; }

        [DisplayName("REF Capa")]
        public string REFCapa { get; set; }
        [DisplayName("Frz Capa")]
        public string FrzCapa { get; set; }
        [DisplayName("Dryer Capa")]
        public string DryerCapa { get; set; }

        [DisplayName("RPM")]
        public string RPM { get; set; }
       
        public string Segment { get; set; }
    
        public string Resolution { get; set; }
      
        public string Color { get; set; }
      
        public string SMART { get; set; }
        public string Programs { get; set; }
        [DisplayName("Frost type")]
        public string Frosttype { get; set; }
       
        public string Type { get; set; }
        [DisplayName("Energy Class")]
        public string EnergyClass { get; set; }
        public string Dimension { get; set; }
        [DisplayName("Outter Display")]
        public string OutterDisplay { get; set; }
        [DisplayName("Outter Display")]
        public string WaterDispenser { get; set; }
        
        [ForeignKey("brands")]
        public double Brandcodebrand { get; set; }

        [ForeignKey("Visits")]
        public int IdVisit { get; set; }

        [ForeignKey("Outlets")]
        public int IdOutlet { get; set; }



        public string Display { get; set; }
        [DisplayName("type")]
        public string Disc { get; set; }

        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public virtual Visits Visits { get; set; }



        public virtual ApplicationUser User { get; set; }


    }

}



