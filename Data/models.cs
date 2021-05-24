using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static CE.Controllers.ModelsController;

namespace CE.Data
{
    [Table(name: "AspNetModels")]
    public class models
    {
        [Key]
        [DisplayName("Code")]
        public int Code { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("code BP")]
        public string CodeBP { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }
        [DisplayName("AV")]
        public AV Availibility { get; set; }
        
        public int Price { get; set; }
        [DisplayName("Market Share")]
        public bool MarketShare { get; set; }
        [DisplayName("Shelf Share")]
        public bool ShelfShare { get; set; }
        public int Stock { get; set; }
        [DisplayName("Type")]

        public string typee { get; set; }
        [DisplayName("W/S")]
        public int Weeklysail { get; set; }
        public string Category { get; set; }
        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
        public virtual ApplicationUser User { get; set; }

    }

    public class AC : models 
    {
        public TypeAC TypeAC { get; set; }
       

        public string Puissance { get; set; }
        public ClassAC Classac { get; set; }

    }
    public class WM : models
    {
        [DisplayName("Type")]

        public TypeWM2 TypeWM2 { get; set; }
        public string Color { get; set; }
        [DisplayName("Size Category")]

        public int SizeCategory { get; set; }
        public SegementWM segementWM { get; set; }
        public string Capacity { get; set; }
     
        public Drying Drying { get; set; }

        [DisplayName("Dryer Capacity")]
        public string DryerCapacity { get; set; }

        public string Technology { get; set; }

        public ClassWM Class { get; set; }

        public Motor Motor { get; set; }
        [DisplayName("Type 2")]

        public TypeWM TypeWM { get; set; }
    }
    public class REF : models
    {
        [DisplayName("Type 2")]

        public TypeREF2 Type2 { get; set; }
        public string Color { get; set; }
        [DisplayName("Segment 1")]

        public Segment Segment { get; set; }
        public string Capacity { get; set; }
        public Energy Energy { get; set; }
        public Class Class { get; set; }
        public Technology Technology { get; set; }
        public Frost Frost { get; set; }
        public Display Display { get; set; }
        [DisplayName("Water dispenser")]
        public Waterdispenser Waterdispenser { get; set; }
        [DisplayName("Type")]

        public TypeREF TypeREF { get; set; }
        [DisplayName("Segment 2")]

        public SegmentREF Segment2 { get; set; }
    }
    public class TV : models
    {
        public ClassTV Class { get; set; }
        [DisplayName("Type")]

        public TypeTV TypeTV { get; set; }
        public string Size { get; set; }
        [DisplayName("Size Category")]
        public int SizeCategory { get; set; }
        public Resolution Resolution { get; set; }
        public Form Form { get; set; }
        [DisplayName("Smart TV")]
        public SmartTV SmartTV { get; set; }
        public segmentTV SegmentTV { get; set; }

    }
    public enum segmentTV
    {

    }
    public enum ClassTV
    {
        Basic,
        Premuim
    }
   
    public enum SmartTV
    { 
        Yes,
        No


    }
    public enum AV
    {
        Yes, 
        No
    }
    public enum Form {
        Curved, 
        Flat
        
    }
    public enum ModelEnum
    {
        AC,
        WM, 
        REF, 
        TV
    }
    public enum TypeTV
    {
        Curved,
        LED,
        OLD,
        QLED
    }
    public enum ClassAC
    {

        Basic,
        Premuim
    }
    
    public enum Resolution
    {
        HD,
        FUllHD,
        UHD
    }
    public enum  TypeREF
    {
        BMF,
        FDR,
        [Display(Name = "Chest freezer")]
        Chestfreezer,
        SBS,
        TMF

    }
    public enum TypeREF2
    {
        Door,
        Twodoor,
        Threedoors,
        Fourdoors

    }
    public enum Waterdispenser
    {
        Yes,
        No
    }
    public enum Segment
    {

        [Display(Name = "<300")] Moin300,
       
        [Display(Name = "300~~400")] Entre300et400,
       [Display(Name = "400~~500")] Entre400et500,
        [Display(Name = ">500")] Plus500




    }
    public enum Energy
    {




        [Display(Name = "1")] un = 1,
        [Display(Name = "2")] deux = 2,
        [Display(Name = "3")] Trois = 3
    

}
    

    public enum Class
    {
        Basic,
        Premuim
    }


    public enum Technology
    {
        Standard,
        [Display(Name = "Integral ventilated cold")]
         Integral_ventilated_cold,
        [Display(Name = "Sièxime Sens FreshControl")]
        sièxime_Sens_FreshControl,
        Multiflow,
        [Display(Name = "Sièxime Sens")]

        sièxime_Sens,
        [Display(Name = "Active Dual Cooling")]
        Active_Dual_Cooling,
        Other

    }
    public enum Frost
    {
        Defrost,
        Nofrost
    }
    public enum Display
    {
        Yes,
        No

    }
    public enum TypeAC
    {
        [Display(Name = "Chaut Froid")]

        Chaut_Froid,
        Chaut

    }

    public enum SegementWM
    {
        [Display(Name = "<7")] moins7,
        [Display(Name = "7")] sept,
        [Display(Name = "8")] huit,
        [Display(Name = "9")] neuf,
        [Display(Name = "10=>12")] entre10et12,
        [Display(Name = ">15")] quinze

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
        
    }

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





