using CAP.Data;
using CAP.Services.Interfaces;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace CAP.Services
{
    public class DataFlowService : IDataFlowService
    {


        //outlets
        public XLWorkbook Export(IList<Outlets> data)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Outlets");
            worksheet.Cell(1, 1).Value = "#";
            worksheet.Cell(1, 2).Value = "Date";
            worksheet.Cell(1, 3).Value = "Marchandisers";
            worksheet.Cell(1, 4).Value = "Account";
            worksheet.Cell(1, 5).Value = "POS Name";
            worksheet.Cell(1, 6).Value = "City";
            worksheet.Cell(1, 7).Value = "Delegation";
            worksheet.Cell(1, 8).Value = "District";
            worksheet.Cell(1, 9).Value = "Street"; 
            worksheet.Cell(1, 10).Value = "Area";
            worksheet.Cell(1, 11).Value = "Channel Type"; 
            worksheet.Cell(1, 12).Value = "Store Size"; 
            worksheet.Cell(1, 13).Value = "Contact Person";
            worksheet.Cell(1, 14).Value = "Contact Person 2"; 
            worksheet.Cell(1, 15).Value = "Website"; 
            worksheet.Cell(1, 16).Value = "Latitude";
            worksheet.Cell(1, 17).Value = "Longitude";
            worksheet.Cell(1, 18).Value = "Full Address";

            worksheet.Cell(1, 19).Value = "Link Google MAPS2";
            worksheet.Cell(1, 20).Value = "Status";
            worksheet.Cell(1, 21).Value = "Est. Ann. T/O (KTND)";
            worksheet.Cell(1, 22).Value = "Av. Monthly T/O";
            worksheet.Cell(1, 23).Value = "Store Class";
            worksheet.Cell(1, 24).Value = "TV Display";
            worksheet.Cell(1, 25).Value = "REF Display";
            worksheet.Cell(1, 26).Value = "WM Display";
            worksheet.Cell(1, 27).Value = "RAC Display";
            worksheet.Cell(1, 28).Value = "Display Status";
            worksheet.Cell(1, 29).Value = "Display Priority";
            worksheet.Cell(1, 30).Value = "SIS";
            worksheet.Cell(1, 31).Value = "SODIG";
            worksheet.Cell(1, 32).Value = "CONDOR"; 
            worksheet.Cell(1, 33).Value = "A2C";
            worksheet.Cell(1, 34).Value = "Couvrage";
            worksheet.Cell(1, 35).Value = "LG Promoters";
            worksheet.Cell(1, 36).Value = "Promoter Remarks";

            for (int index = 1; index <= data.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = data[index - 1].IdOutlet;
                worksheet.Cell(index + 1, 2).Value = data[index - 1].Date;
                worksheet.Cell(index + 1, 3).Value = data[index - 1]?.User?.UserName;
                worksheet.Cell(index + 1, 4).Value = data[index - 1].Account;
                worksheet.Cell(index + 1, 5).Value = data[index - 1].POSName;

                worksheet.Cell(index + 1, 6).Value = data[index - 1].City;
                worksheet.Cell(index + 1, 6).Value = data[index - 1].Delegation;
                worksheet.Cell(index + 1, 7).Value = data[index - 1].District;
                worksheet.Cell(index + 1, 8).Value = data[index - 1].Street;
                worksheet.Cell(index + 1, 9).Value = data[index - 1].Area;
                worksheet.Cell(index + 1, 10).Value = data[index - 1].Channeltype;
                worksheet.Cell(index + 1, 11).Value = data[index - 1].StoreSize;
                worksheet.Cell(index + 1, 13).Value = data[index - 1].ContactPerson;
                worksheet.Cell(index + 1, 14).Value = data[index - 1].ContactPerson2;
                worksheet.Cell(index + 1, 15).Value = data[index - 1].Website;
                worksheet.Cell(index + 1, 16).Value = data[index - 1].Latitude;
                worksheet.Cell(index + 1, 17).Value = data[index - 1].Longitude;
                worksheet.Cell(index + 1, 18).Value = data[index - 1].FullAddress;
                worksheet.Cell(index + 1, 19).Value = data[index - 1].LinkGoogleMAPS;
                worksheet.Cell(index + 1, 20).Value = data[index - 1].Status;
                worksheet.Cell(index + 1, 21).Value = data[index - 1].Estann;
                worksheet.Cell(index + 1, 22).Value = data[index - 1].AVMonthly;
                worksheet.Cell(index + 1, 23).Value = data[index - 1].StoreClass;
                worksheet.Cell(index + 1, 24).Value = data[index - 1].TVDisplay;
                worksheet.Cell(index + 1, 25).Value = data[index - 1].REFDisplay;
                worksheet.Cell(index + 1, 26).Value = data[index - 1].WMDisplay;
                worksheet.Cell(index + 1, 27).Value = data[index - 1].RACDisplay;
                worksheet.Cell(index + 1, 28).Value = data[index - 1].Displaystatus;
                worksheet.Cell(index + 1, 29).Value = data[index - 1].DisplayPriority;
                worksheet.Cell(index + 1, 30).Value = data[index - 1].SIS;
                worksheet.Cell(index + 1, 31).Value = data[index - 1].SODIG;
                worksheet.Cell(index + 1, 32).Value = data[index - 1].CONDOR;
                worksheet.Cell(index + 1, 33).Value = data[index - 1].A2C;
                worksheet.Cell(index + 1, 34).Value = data[index - 1].Coverage;
                worksheet.Cell(index + 1, 35).Value = data[index - 1].LGPromoters;
                worksheet.Cell(index + 1, 36).Value = data[index - 1].PromoterRemarks;


            }
            return workbook;
        }
        public void Import(IList<Outlets> data)
        {
            throw new NotImplementedException();
        }

        //visits 
        public XLWorkbook Exportvisit(IList<Visits> datavisit)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Visits");
            worksheet.Cell(1, 1).Value = "IdVisit";
            worksheet.Cell(1, 2).Value = "SFO";
            worksheet.Cell(1, 3).Value = "Date";
            worksheet.Cell(1, 4).Value = "Year"; 
            worksheet.Cell(1, 5).Value = "Month";
            worksheet.Cell(1, 6).Value = "Week";
            worksheet.Cell(1, 7).Value = "POS Name";
            worksheet.Cell(1, 8).Value = "Model Name";
            worksheet.Cell(1, 9).Value = "Brand";
            worksheet.Cell(1, 10).Value = "Product type";
            worksheet.Cell(1, 11).Value = " Capacity / Size";
            worksheet.Cell(1, 12).Value = "Segment";
            worksheet.Cell(1, 13).Value = "Color";
            worksheet.Cell(1, 14).Value = "Type";
            worksheet.Cell(1, 15).Value = "Presence";
            worksheet.Cell(1, 16).Value = "Sales (Q)";
            worksheet.Cell(1, 17).Value = "Price";
            worksheet.Cell(1, 18).Value = "Sales (A)";


            for (int index = 1; index <= datavisit.Count; index++)
            {
               
                worksheet.Cell(index + 1, 1).Value = datavisit[index - 1].IdVisit;
                worksheet.Cell(index + 1, 2).Value = datavisit[index - 1].User.UserName;
                worksheet.Cell(index + 1, 3).Value = datavisit[index - 1].Date;
                worksheet.Cell(index + 1, 4).Value = datavisit[index - 1].Date.Year;
                worksheet.Cell(index + 1, 5).Value = datavisit[index - 1].Date.Month;
                worksheet.Cell(index + 1, 6).Value = datavisit[index - 1].GetWeekNumber();
                worksheet.Cell(index + 1, 7).Value = datavisit[index - 1].Outlets.POSName;
                worksheet.Cell(index + 1, 8).Value = datavisit[index - 1].Models.ModelName;
                worksheet.Cell(index + 1, 9).Value = datavisit[index - 1].Brand.Namebrand;
                worksheet.Cell(index + 1, 10).Value = datavisit[index - 1].Models.ProductType;
                worksheet.Cell(index + 1, 11).Value = datavisit[index - 1].Models.SizeCapacity;
                worksheet.Cell(index + 1, 12).Value = datavisit[index - 1].Models.Segment;
                worksheet.Cell(index + 1, 13).Value = datavisit[index - 1].Models.Color;
                worksheet.Cell(index + 1, 14).Value = datavisit[index - 1].Models.Type;
                worksheet.Cell(index + 1, 15).Value = datavisit[index - 1].Presence;
                worksheet.Cell(index + 1, 16).Value = datavisit[index - 1].SalesQ;
                worksheet.Cell(index + 1, 17).Value = datavisit[index - 1].Models.Price;
                worksheet.Cell(index + 1, 18).Value = datavisit[index - 1].SalesA;


            }
            return workbook;
        }

      
        // models 

        public XLWorkbook Export(IList<models> datamodel)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Models");
            worksheet.Cell(1, 1).Value = "Code";
            worksheet.Cell(1, 2).Value = "CodeBP";
            worksheet.Cell(1, 3).Value = "Name";
            worksheet.Cell(1, 4).Value = "Brand";
            worksheet.Cell(1, 5).Value = "Rang";
            for (int index = 1; index <= datamodel.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = datamodel[index - 1].Code;
               // worksheet.Cell(index + 1, 2).Value = datamodel[index - 1].CodeBP;
               // worksheet.Cell(index + 1, 3).Value = datamodel[index - 1].Name;
                worksheet.Cell(index + 1, 4).Value = datamodel[index - 1].Brand;

            }
            return workbook;
        }

        public void Import(IList<models> datamodel)
        {
            throw new NotImplementedException();
        }
        public XLWorkbook ExportBrands(IList<brands> dataBrands)
        {
            {
                var workbook = new XLWorkbook();
                IXLWorksheet worksheet = workbook.Worksheets.Add("brands");
                worksheet.Cell(1, 1).Value = "codebrand";
                worksheet.Cell(1, 2).Value = "Namebrand";
                worksheet.Cell(1, 3).Value = "Color";


                for (int index = 1; index <= dataBrands.Count; index++)
                {
                    worksheet.Cell(index + 1, 1).Value = dataBrands[index - 1].codebrand;
                    worksheet.Cell(index + 1, 2).Value = dataBrands[index - 1].Namebrand;
                    worksheet.Cell(index + 1, 3).Value = dataBrands[index - 1].Color;


                }
                return workbook;
            }
        }
        public void ImportBrands(IList<brands> dataBrands)
        {
            throw new NotImplementedException();
        }


    }

}