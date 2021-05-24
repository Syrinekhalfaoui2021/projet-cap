using ClosedXML.Excel;
using CE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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