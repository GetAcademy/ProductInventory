using ProductInventory.Core.DomainModel;

namespace ProductInventory.Core.DomainServices
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product?> FindAsync(int id);

        Task<int> CreateAsync(Product product);

        Task<bool> UpdateStockAsync(int id, int newStockCount);

        Task<bool> DeleteAsync(int id);
    }
}
