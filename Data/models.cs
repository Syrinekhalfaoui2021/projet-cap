using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Name { get; set; }
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
        [ForeignKey("brands")]
        
        public double Codebrand { get; set; }

        public string Display { get; set; }
        [DisplayName("type")]
        public string Disc { get; set; }

        public virtual Outlets Outlets { get; set; }
        public virtual brands Brand { get; set; }
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
        public string Form { get; set; }
        [DisplayName("Smart TV")]
        public string SmartTV { get; set; }
        public string SegmentTV { get; set; }
        public string Integrated_Receiver { get; set; }
        public double HDMI { get; set; }

        public double USB { get; set; }

    }
    public enum Inverter
    {
        [Display(Name = "Non inverter")]

        Noninverter,
        Inverter


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
    public enum Form
    {
        Curved,
        Flat

    }
    public enum ModelEnum
    {
        AC,
        WM,
        REF,
        TV,
        DW
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
    public enum TypeREF
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
        [Display(Name = "C/F")]

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





