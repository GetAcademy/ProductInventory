using ProductInventory.Core.DomainModel;
using ProductInventory.Core.DomainServices;

namespace ProductInventory.Core.ApplicationService
{
    internal class ProductService(IProductRepository repo)
    {
        public async Task<Result<Product>> CreateProductAsync(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return Result<Product>.Failure("Navn må fylles ut.");
            }

            if (string.IsNullOrWhiteSpace(product.ProductCode))
            {
                return Result<Product>.Failure("Produktkode må fylles ut.");
            }

            if (product.StockCount < 0)
            {
                return Result<Product>.Failure("Lagerbeholdning kan ikke være negativ.");
            }

            await repo.CreateAsync(product);

            return Result<Product>.Success(product);
        }
    }
}
