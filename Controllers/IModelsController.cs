using CE.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CE.Controllers
{
    public interface IModelsController
    {
        IActionResult AddOrEditBrandsAsync(int id = 0);
        Task<IActionResult> AddOrEditBrands(int id, [Bind(new[] { "codebrand,Namebrand,Color" })] brands brands);
        IActionResult AddOrEditModels();
        IActionResult AddOrEditModels(ModelEnum SelectedModel);
        IActionResult AddOrEditsammary(int id = 0);
        Task<IActionResult> AddOrEditsammary(int id, [Bind(new[] { "Idsammary" })] SammaryReport sammaryweekly);
        Task<IActionResult> DeleteBrands(int? id);
        Task<IActionResult> DeleteModels(int? id);
        Task<IActionResult> Deletesammary(int? id);
        Task<IActionResult> DownloadExcelDocumentBrands();
        Task<IActionResult> DownloadExcelDocumentModel();
        IActionResult ImportExcelDocumentBrands([FromForm(Name = "file")] IFormFile input);
        IActionResult ImportExcelDocumentmodel([FromForm(Name = "file")] IFormFile input);
        Task<IActionResult> IndexBrands();
        Task<IActionResult> IndexModels();
        Task<IActionResult> Indexsammaryweekly();
        Task<IActionResult> SearchmodelAsync(string search);
    }
}