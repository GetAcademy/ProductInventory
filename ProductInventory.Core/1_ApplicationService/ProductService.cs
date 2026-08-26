using ProductInventory.Core._2_DomainServices;
using ProductInventory.Core._3_DomainModel;

namespace ProductInventory.Core._1_ApplicationService
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

            var id = await repo.CreateAsync(product);
            product.Id = id;
            return Result<Product>.Success(product);
        }
    }
}
