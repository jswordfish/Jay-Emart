using EMartV2.Models.ProductModels;
using System.Threading.Tasks;

namespace EMartV2.BuisnessLayer.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int id);
    }
}
