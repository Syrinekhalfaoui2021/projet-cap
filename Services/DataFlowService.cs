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
            worksheet.Cell(1, 1).Value = "Code";
            worksheet.Cell(1, 2).Value = "Date";
            worksheet.Cell(1, 3).Value = "SFO";
            worksheet.Cell(1, 4).Value = "Outlet";
            worksheet.Cell(1, 5).Value = "City";
            worksheet.Cell(1, 6).Value = "Delegation";
            worksheet.Cell(1, 7).Value = "District";
            worksheet.Cell(1, 8).Value = "Street";
            worksheet.Cell(1, 9).Value = "Area";
            worksheet.Cell(1, 10).Value = "Channel";
            worksheet.Cell(1, 11).Value = "Type";
            worksheet.Cell(1, 12).Value = "Store size";
            worksheet.Cell(1, 13).Value = "Zone";
            worksheet.Cell(1, 14).Value = "Contact personnel";
            worksheet.Cell(1, 15).Value = "Phone Number";
            worksheet.Cell(1, 16).Value = "Website";
            worksheet.Cell(1, 17).Value = "Latitude";
            worksheet.Cell(1, 18).Value = "Longitude";
            worksheet.Cell(1, 19).Value = "Full adress";
            worksheet.Cell(1, 20).Value = "Link Google MAPS2";
            worksheet.Cell(1, 21).Value = "Status";
            worksheet.Cell(1, 22).Value = "AV"; 
            worksheet.Cell(1, 23).Value = "HA";
            worksheet.Cell(1, 24).Value = "Couvrage";
            worksheet.Cell(1, 25).Value = "Antena";

            for (int index = 1; index <= data.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = data[index - 1].IdOutlet;
                worksheet.Cell(index + 1, 2).Value = data[index - 1].Date;
                worksheet.Cell(index + 1, 3).Value = data[index - 1]?.User?.UserName;
                worksheet.Cell(index + 1, 4).Value = data[index - 1].Account;

                worksheet.Cell(index + 1, 5).Value = data[index - 1].City;
                worksheet.Cell(index + 1, 6).Value = data[index - 1].Delegation;
                worksheet.Cell(index + 1, 7).Value = data[index - 1].District;
                worksheet.Cell(index + 1, 8).Value = data[index - 1].Street;
                worksheet.Cell(index + 1, 9).Value = data[index - 1].Area;
                worksheet.Cell(index + 1, 10).Value = data[index - 1].Channeltype;
                worksheet.Cell(index + 1, 11).Value = data[index - 1].StoreSize;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Zone;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].ContactPerson;
              //  worksheet.Cell(index + 1, 12).Value = data[index - 1].PhoneNumber;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Website;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Latitude;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Longitude;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].FullAddress;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].LinkGoogleMAPS;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].AV;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].HA;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Coverage;
                worksheet.Cell(index + 1, 12).Value = data[index - 1].Antenna;


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
                worksheet.Cell(index + 1, 2).Value = datavisit[index - 1].User?.UserName;
                worksheet.Cell(index + 1, 3).Value = datavisit[index - 1]?.Date;
                worksheet.Cell(index + 1, 3).Value = datavisit[index - 1]?.Outlets.Zone;

                }
                return workbook;
            }
        }
        public void Importvisitweekly(IList<Visitsweekly> datavisitweekly)
        {
            throw new NotImplementedException();
        }
        //visits monthly

        public XLWorkbook Exportvisitmonthly(IList<Visitsmonthly> datavisitmonthly)
        {
            {
                var workbook = new XLWorkbook();
                IXLWorksheet worksheet = workbook.Worksheets.Add("Visits");
                worksheet.Cell(1, 1).Value = "IdVisit";
                worksheet.Cell(1, 2).Value = "SFO";
                worksheet.Cell(1, 3).Value = "Date";
                worksheet.Cell(1, 4).Value = "Zone";

                for (int index = 1; index <= datavisitmonthly.Count; index++)
                {
                    worksheet.Cell(index + 1, 1).Value = datavisitmonthly[index - 1].IdVisit;
                    worksheet.Cell(index + 1, 2).Value = datavisitmonthly[index - 1].User?.UserName;
                    worksheet.Cell(index + 1, 3).Value = datavisitmonthly[index - 1]?.Date;
                    worksheet.Cell(index + 1, 4).Value = datavisitmonthly[index - 1].Outlet.Zone;
                    worksheet.Cell(index + 1, 5).Value = datavisitmonthly[index - 1].Outlet.Account;


                }
                return workbook;
            }
        }
        public void Importvisitmonthly(IList<Visitsmonthly> datavisitmonthly)
        {
            throw new NotImplementedException();
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
                worksheet.Cell(index + 1, 2).Value = datamodel[index - 1].CodeBP;
                worksheet.Cell(index + 1, 3).Value = datamodel[index - 1].Name;
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