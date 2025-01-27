using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{

    // Classe que representa um produto
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class ProductService
    {
        public async Task<List<Product>> FetchAndProcessProductsAsync(List<int> productIds)
        {
            // 1. Busca os produtos
            Console.WriteLine("Buscando informações dos produtos...");
            var productTasks = new List<Task<Product>>();

            foreach (var id in productIds)
            {
                productTasks.Add(FetchProductDataAsync(id));
            }

            var products = await Task.WhenAll(productTasks);

            // 2. Processa os produtos
            Console.WriteLine("Processando os produtos...");
            var processedProducts = new List<Product>();

            foreach (var product in products)
            {
                processedProducts.Add(await ProcessProductAsync(product));
            }

            return processedProducts;
        }

        // Simula a busca de informações de um produto
        private async Task<Product> FetchProductDataAsync(int productId)
        {
            await Task.Delay(1000); // Simula atraso na API
            Console.WriteLine($"[FetchProductDataAsync] Produto {productId} obtido.");

            return new Product
            {
                Id = productId,
                Name = $"Produto-{productId}",
                Price = new Random().Next(100, 1000)
            };
        }

        // Simula o processamento do produto
        private static async Task<Product> ProcessProductAsync(Product product)
        {
            await Task.Delay(500); // Simula o processamento
            var discount = 0.1m; // 10% de desconto

            product.Price -= product.Price * discount;
            Console.WriteLine($"[ProcessProductAsync] Produto {product.Id} processado com desconto.");

            return product;
        }
    }
}
