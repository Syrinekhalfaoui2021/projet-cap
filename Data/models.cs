using System.Collections.Generic;
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
    
        [DisplayName("Model Name")]
        public string ModelName { get; set; }
        [DisplayName("AV")]
        public string Availibility { get; set; }

        public string Price { get; set; }
        [DisplayName("Market Share")]
        public string MarketShare { get; set; }
        [DisplayName("Shelf Share")]
        public string ShelfShare { get; set; }
        public string Stock { get; set; }
       
        [DisplayName("W/S")]
        public string Weeklysail { get; set; }
        public string Category { get; set; }

        [ForeignKey("brands")]
        public double Brandcodebrand { get; set; }

        [ForeignKey("Visits")]
        public int? IdVisit { get; set; }

        [ForeignKey("Outlets")]
        public int? IdOutlet { get; set; }



        public string Display { get; set; }
        [DisplayName("type")]
        public string Disc { get; set; }
        public virtual Visitsweekly Visitsweekly { get; set; }
        public virtual Visitsmonthly Visitsmonthly { get; set; }
        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public virtual Visits Visits{ get; set; }

       

        public virtual ApplicationUser User { get; set; }

    }
    public class DW : models
    {


        public string  Encastrable { get; set; }
        public string Color { get; set; }
        public double Promgramme { get; set; }
        [DisplayName("Number of covers")]

        public double Numberofcovers { get; set; }
        [DisplayName("Energetic efficiency")]
        public double Energeticefficiency { get; set; }
    }

    public class AC : models
    {
        [DisplayName("Type")]

        public string TypeAC { get; set; }
        public string Inverter { get; set; }



        public double Puissance { get; set; }
        [DisplayName("Class")]

        [NotMapped]
        public int ClassasNumber { get; set; }
        public ClassAC Classac { get; set; }
        [DisplayName("Energetic class")]

        public string Energeticclass { get; set; }



    }
    public class WM : models
    {
        [DisplayName("Type ")]

        public string TypeWM { get; set; }

        [DisplayName("Type 2")]

        public string TypeWM2 { get; set; }
        public string Color { get; set; }
        [DisplayName("Size Category")]

        public int SizeCategory { get; set; }
        [DisplayName("Segment")]

        public string segementWM { get; set; }
        public double Capacity { get; set; }

        public string Drying { get; set; }

        [DisplayName("Dryer Capacity")]
        public double DryerCapacity { get; set; }

        public string Technology { get; set; }

        public string Class { get; set; }

        public string Motor { get; set; }
      

    }
    public class REF : models
    {
        [DisplayName("Type 2")]

        public string Typeref { get; set; }
        public string Color { get; set; }
        [DisplayName("Segment 1")]

        public string Segment { get; set; }
        public double Capacity { get; set; }
        public Energy Energy { get; set; }
        public string Class { get; set; }
        public string Technology { get; set; }
        public string Frost { get; set; }
        [DisplayName("Water dispenser")]
        public string Waterdispenser { get; set; }
        [DisplayName("Type")]

        public string TypeREF2 { get; set; }
        [DisplayName("Segment 2")]

        public string Segment2 { get; set; }
        
        [DisplayName("Energetic class")]

        public double EnergeticClassREf { get; set; }

    }
    public class TV : models
    {
        public ClassTV Class { get; set; }
        [DisplayName("Type")]

        public string TypeTV { get; set; }
        public string Size { get; set; }
        [DisplayName("Size Category")]
        public int SizeCategory { get; set; }
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

    }
    public enum TypeWM
    {
        [Display(Name = "Active Dual Wash")]
        active_dual_wash,
        COMBO,
        [Display(Name = "Front loading")]
        Front_loading,
        [Display(Name = "TOP loading")]
        TOP_loading,
        [Display(Name = "Twin Tub")]

        Twin_Tub
    }
    public enum TypeWM2
    {
        [Display(Name = "ADD wash")]

        ADD_wash,
        Other
    }
    public enum SizeCategoryWM
    {

        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public virtual Visits Visits { get; set; }

    public enum Drying
    {
        Yes,
        No
    }

    public enum Motor
    {
        None,
        [Display(Name = "Direct drive")]

        Direct_drive,
        [Display(Name = "Digital inverter")]

        Digital_inverter,
        [Display(Name = "Motor prosmart inve")]

        Motor_prosmart_inve,
        Inverter,
        inerter
    }
    public enum ClassWM
    {
        Basic,
        Premuim
    }
    public enum Color
    {
        Silver,
        White,
        Inox

    }
    public enum SegmentREF
    {
        [Display(Name = "<230")]
        moins230,
        [Display(Name = "271-300")]
        entre271et300,
        [Display(Name = "301-320")]
        entre301et320,
        [Display(Name = "321-350")]
        entre321et350,
        [Display(Name = "351-380")]
        entre351et380,
        [Display(Name = "381-400")]
        entre381et400,
        [Display(Name = "401-420")]
        entre401et420,
        [Display(Name = "421-450")]
        entre421et450,
        [Display(Name = "451-480")]
        entre451et480,
        [Display(Name = "481-510")]
        entre481et510,
        [Display(Name = "511-530")]
        entre511et530,
        [Display(Name = "531-560")]
        entre531et560,
        [Display(Name = "561-600")]
        entre561et600,
        [Display(Name = ">500")]
        plus500
    }
}





