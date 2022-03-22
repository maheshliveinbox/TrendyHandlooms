using API.Models;

namespace API.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> List();
    }
}
