using CAP.Data;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace CAP.Services.Interfaces
{
    public interface IDataFlowService
    {
        XLWorkbook Export(IList<Outlets> data);

        XLWorkbook Export(IList<models> datamodel);
        void Import(IList<models> datamodel);
        XLWorkbook Exportvisit(IList<Visits> datavisit);
  
        XLWorkbook ExportBrands(IList<brands> dataBrands);

    }
}