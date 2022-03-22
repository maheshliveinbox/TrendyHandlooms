using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ProductModel>> List()
        {
            var products = await (from product in dbContext.Products
                                  select new ProductModel()
                                  {
                                      Id=product.Id,
                                      Name=product.Name,
                                  }).ToListAsync();

            return products;
        }
    }
}
