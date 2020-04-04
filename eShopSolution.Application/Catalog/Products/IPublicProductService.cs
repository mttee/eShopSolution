using eShopSolution.ViewModels.Catalog.Products;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.Common;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        //Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
