using LMC.CQRS.Demo.Api.Data.Models;

namespace LMC.CQRS.Demo.Api.Data
{
    public class FakeDataStore
    {
        private static List<Product> _products = new List<Product>();

        public FakeDataStore()
        {
            for (int i = 1; i <= 3; i++)
            {
                _products.Add(new Product { Id = i, Name = $"Test Product {i}" });
            }
        }

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetProductById(int id) => await Task.FromResult(_products.Single(p => p.Id == id));
    }
}
