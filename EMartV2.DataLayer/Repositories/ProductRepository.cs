using EMartV2.DataLayer.Interfaces;
using EMartV2.Models.ProductModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EMartV2.DataLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EMartContext _context;
        public ProductRepository(EMartContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                    return product;
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            try
            {
                var prdouct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
                return prdouct;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
