using CE.Data;
using ClosedXML.Excel;
using System.Collections.Generic;

namespace CE.Services.Interfaces
{
    public interface IDataFlowService
    {
        XLWorkbook Export(IList<Outlets> data);

        XLWorkbook Export(IList<models> datamodel);
        void Import(IList<models> datamodel);
        XLWorkbook Exportvisitdaily(IList<Visits> datavisitdaily);
        XLWorkbook Exportvisitweekly(IList<Visitsweekly> datavisitweekly);
        XLWorkbook Exportvisitmonthly(IList<Visitsmonthly> datavisitmonthly);
        XLWorkbook ExportBrands(IList<brands> dataBrands);

    }
}