using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAP.Data
{
    [Table(name: "AspNetOutlet")]
    public class Outlets
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [DisplayName("Code")]
        public int IdOutlet { get; set; }

        [DisplayName("Account")]
        public string Account  { get; set; }

        [DisplayName("Date")]
    
        public DateTime Date { get; set; }
        [DisplayName("Est.Ann.T/O(KTND)")]

        public string Estann { get; set; }

        [DisplayName("Av. Monthly T/O")]

        public string AVMonthly { get; set; }
        [DisplayName("TV Display")]

        public string TVDisplay { get; set; }
        [DisplayName("REF Display")]

        public string REFDisplay { get; set; }
        [DisplayName("RAC Display")]

        public string RACDisplay { get; set; }
        [DisplayName("WM Display")]

        public string WMDisplay { get; set; }
        [DisplayName("Display Status")]
        
        public string Displaystatus { get; set; }
        [DisplayName("Display Priority")]
        
        public string DisplayPriority { get; set; }
        public string SIS { get; set; }
        public string SODIG { get; set; }
        public string CONDOR { get; set; }
        public string A2C { get; set; }
        [DisplayName("LG Promoters")]

        public string LGPromoters { get; set; }
        [DisplayName("Promoter Remarks")]

        public string PromoterRemarks { get; set; }
     
       


       [DisplayName("POS Name")]

        public string POSName { get; set; }
      

        [DisplayName("Key dealer")]
        public string Keydealer { get; set; }

        public string Compte { get; set; }

        public string Type { get; set; }
     

        public string Class { get; set; }
      

        public string Activity { get; set; }

        public string Zone { get; set; }


        public string District { get; set; }

        public string City { get; set; }
        public string Website { get; set; }
        public string  ContactPerson { get; set; }
    
        public string ContactPerson2 { get; set; }
   

        public string Longitude { get; set; }
        public string Delegation { get; set; }
      
        [DisplayName("Store Class")]

        public string StoreClass { get; set; }

        public string Latitude { get; set; }
        [DisplayName("Full Address")]

        public string FullAddress { get; set; }
        [DisplayName("Link Google MAPS2")]

        public string LinkGoogleMAPS { get; set; }
        public string Street { get; set; }
        [DisplayName("Outlet type")]
        public string Outletstype { get; set; }
        [DisplayName("Store Size")]

        public string  StoreSize { get; set; }
        [DisplayName("Channel type")]
        public string Channeltype { get; set; }
        public string Retailer { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }

        public string Coverage { get; set; }
        public string Antenna { get; set; }
        public string HA { get; set; }
        public string AV { get; set; }

        
        [ForeignKey("User")]
        public string UserId { get; set; }


        public virtual Visits Visitss { get; set; }
     
        public virtual ApplicationUser User { get; set; }



    }
}

