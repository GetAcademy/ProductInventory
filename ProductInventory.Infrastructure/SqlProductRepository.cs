using Dapper;
using Microsoft.Data.SqlClient;
using ProductInventory.Core._2_DomainServices;
using ProductInventory.Core._3_DomainModel;

namespace ProductInventory.Infrastructure
{
    internal class SqlProductRepository(string connectionString) : IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateAsync(Product product)
        {
            const string sql =
                """
                INSERT INTO Products
                    (Name, ProductCode, StockCount)
                OUTPUT INSERTED.Id
                VALUES
                    (@Name, @ProductCode, @StockCount);
                """;

            await using var connection = new SqlConnection(connectionString);
            return await connection.QuerySingleAsync<int>(sql, product);
        }

        public Task<bool> UpdateStockAsync(int id, int newStockCount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
