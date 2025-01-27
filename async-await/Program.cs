using async_await;

Task incrementoTask = Operacoes.IncrementoAsync();
Task decrementoTask = Operacoes.DecrementoAsync();

await incrementoTask;
await decrementoTask;

Console.WriteLine("Operações realizadas assincronas.");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-");

Operacoes.Incremento();
Operacoes.Decremento();

Console.WriteLine("Operações realizadas sincronas");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("Simulando uma chamada API com Async/Await");


Console.WriteLine("Iniciando o sistema...");

// Instancia o serviço responsável pelas operações
var productService = new ProductService();

// Simulando IDs de produtos
var productIds = new List<int> { 101, 102, 103 };

// Realiza o fluxo de buscar e processar produtos
var processedProducts = await productService.FetchAndProcessProductsAsync(productIds);

// Exibe os resultados
Console.WriteLine("\nProdutos processados:");
foreach (var product in processedProducts)
{
    Console.WriteLine($"ID: {product.Id}, Nome: {product.Name}, Preço com desconto: {product.Price:C}");
}
