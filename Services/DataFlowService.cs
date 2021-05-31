using CE.Data;
using CE.Services.Interfaces;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace CE.Services
{
    public class DataFlowService : IDataFlowService
    {


        //outlets
        public XLWorkbook Export(IList<Outlets> data)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Outlets");
            worksheet.Cell(1, 1).Value = "Code";
            worksheet.Cell(1, 2).Value = "Name";
            worksheet.Cell(1, 3).Value = "SFO";
            worksheet.Cell(1, 4).Value = "Zone";
            worksheet.Cell(1, 5).Value = "State";
            worksheet.Cell(1, 6).Value = "City";
            worksheet.Cell(1, 7).Value = "District";
            worksheet.Cell(1, 8).Value = "Channel";
            worksheet.Cell(1, 9).Value = "Outletstype";
            worksheet.Cell(1, 10).Value = "Class";
            worksheet.Cell(1, 11).Value = "keydealer";

            for (int index = 1; index <= data.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = data[index - 1].IdOutlet;
                worksheet.Cell(index + 1, 2).Value = data[index - 1].NameOutlet;
                worksheet.Cell(index + 1, 3).Value = data[index - 1]?.User?.UserName;
                worksheet.Cell(index + 1, 4).Value = data[index - 1].Zone;
                worksheet.Cell(index + 1, 5).Value = data[index - 1].State;
                worksheet.Cell(index + 1, 6).Value = data[index - 1].City;
                worksheet.Cell(index + 1, 7).Value = data[index - 1].District;
                worksheet.Cell(index + 1, 8).Value = data[index - 1].Channel;
                worksheet.Cell(index + 1, 9).Value = data[index - 1].Outletstype;
                worksheet.Cell(index + 1, 10).Value = data[index - 1].Class;
                worksheet.Cell(index + 1, 11).Value = data[index - 1].Keydealer;
            }
            return workbook;
        }
        public void Import(IList<Outlets> data)
        {
            throw new NotImplementedException();
        }

        //visits daily
        public XLWorkbook Exportvisitdaily(IList<Visits> datavisitdaily)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Visits");
            worksheet.Cell(1, 1).Value = "IdVisit";
            worksheet.Cell(1, 2).Value = "SFO";
            worksheet.Cell(1, 3).Value = "Date";
            worksheet.Cell(1, 4).Value = "Zone";

            for (int index = 1; index <= datavisitdaily.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = datavisitdaily[index - 1].IdVisit;
                worksheet.Cell(index + 1, 2).Value = datavisitdaily[index - 1].User?.UserName;
                worksheet.Cell(index + 1, 3).Value = datavisitdaily[index - 1]?.Date;
                worksheet.Cell(index + 1, 3).Value = datavisitdaily[index - 1]?.Outlets.Zone;

            }
            return workbook;
        }

        public void Importvisitdaily(IList<Visits> datavisitdaily)
        {
            throw new NotImplementedException();
        }
        //visits weekly
        public XLWorkbook Exportvisitweekly(IList<Visitsweekly> datavisitweekly)
        {
            {
                var workbook = new XLWorkbook();
                IXLWorksheet worksheet = workbook.Worksheets.Add("Visits");
                worksheet.Cell(1, 1).Value = "IdVisit";
                worksheet.Cell(1, 2).Value = "SFO";
                worksheet.Cell(1, 3).Value = "Date";
                worksheet.Cell(1, 4).Value = "Zone";
                worksheet.Cell(1, 4).Value = "NameOutlet";



                for (int index = 1; index <= datavisitweekly.Count; index++)
                {
                    worksheet.Cell(index + 1, 1).Value = datavisitweekly[index - 1].IdVisit;
                    worksheet.Cell(index + 1, 2).Value = datavisitweekly[index - 1].User?.UserName;
                    worksheet.Cell(index + 1, 3).Value = datavisitweekly[index - 1]?.Date;
                    worksheet.Cell(index + 1, 4).Value = datavisitweekly[index - 1].Outlets.Zone;
                    worksheet.Cell(index + 1, 5).Value = datavisitweekly[index - 1].Outlets.NameOutlet;


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
                    worksheet.Cell(index + 1, 5).Value = datavisitmonthly[index - 1].Outlet.NameOutlet;


                }
                return workbook;
            }
        }
        public void Importvisitmonthly(IList<Visitsmonthly> datavisitmonthly)
        {
            throw new NotImplementedException();
        }

        // models 

        public XLWorkbook Export(IList<AC> datamodel)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Models");
            worksheet.Cell(1, 1).Value = "Code";
            worksheet.Cell(1, 2).Value = "Name";
            worksheet.Cell(1, 3).Value = "Brand";
            worksheet.Cell(1, 4).Value = "TypeAC";
            worksheet.Cell(1, 5).Value = "Puissance";
            worksheet.Cell(1, 6).Value = "Inverter";
            worksheet.Cell(1, 7).Value = "Energeticclass";
            worksheet.Cell(1, 8).Value = "Classac";
            worksheet.Cell(1, 9).Value = "price";





            for (int index = 1; index <= datamodel.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = datamodel[index - 1].Code;
                worksheet.Cell(index + 1, 2).Value = datamodel[index - 1].Name;
                worksheet.Cell(index + 1, 3).Value = datamodel[index - 1].Brand.Namebrand;
                worksheet.Cell(index + 1, 4).Value = datamodel[index - 1].TypeAC;
                worksheet.Cell(index + 1, 5).Value = datamodel[index - 1].Puissance;
                worksheet.Cell(index + 1, 6).Value = datamodel[index - 1].Inverter;
                worksheet.Cell(index + 1, 7).Value = datamodel[index - 1].Energeticclass;
                worksheet.Cell(index + 1, 8).Value = datamodel[index - 1].Classac;
                worksheet.Cell(index + 1, 8).Value = datamodel[index - 1].Price;






            }
            return workbook;
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

        public void Import(IList<AC> datamodel)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.Export(IList<Outlets> data)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.Export(IList<AC> datamodel)
        {
            throw new NotImplementedException();
        }

        void IDataFlowService.Import(IList<AC> datamodel)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.Exportvisitdaily(IList<Visits> datavisitdaily)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.Exportvisitweekly(IList<Visitsweekly> datavisitweekly)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.Exportvisitmonthly(IList<Visitsmonthly> datavisitmonthly)
        {
            throw new NotImplementedException();
        }

        XLWorkbook IDataFlowService.ExportBrands(IList<brands> dataBrands)
        {
            throw new NotImplementedException();
        }

        object IDataFlowService.Export(List<models> datamodel)
        {
            throw new NotImplementedException();
        }
    }

}