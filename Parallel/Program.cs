using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Pressione ENTER para iniciar");
Console.ReadLine();

// Invocar os métodos que vamos executar
Parallel.Invoke(
   new Action(ExibirDias),
   new Action(ListarLetras),
   new Action(ListarNumeros),
   new Action(ListarComParallelFor),
   new Action(ListarComParallelForEach)
);

// Aguardar a continuação do programa
Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
Console.ReadLine();

static void ExibirDias()
{
    string[] diasArray = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
    foreach (string dia in diasArray)
    {
        Console.WriteLine("Dia da semana: {0}", dia);
        Task.Delay(500).Wait();
    }
}

static void ListarLetras()
{
    string[] letras = 
    { 
        "A", "B", "C", "D","E", "F", "G",
        "H", "I", "J", "K", "L" 
    };

    foreach (string letra in letras)
    {
        Console.WriteLine("Letra : {0}", letra);
        Task.Delay(500).Wait();
    }
}

static void ListarNumeros()
{
    int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    foreach (int numero in numeros)
    {
        Console.WriteLine("Números: {0}", numero);
        Task.Delay(500).Wait();
    }
}

static void ListarComParallelFor()
{
    Parallel.For(0, 10, i =>
    {
        Console.WriteLine($"Início da iteração com Paralle.For {i} na thread {Task.CurrentId}");
        Task.Delay(500).Wait();
        Console.WriteLine($"Fim da iteração {i}");
    });

    Console.WriteLine("Finalizado Paralle.For!");
}
static void ListarComParallelForEach()
{
    var nomes = new List<string> { "Jonas", "Fulan", "Ciclano", "Beltrano", "Testando" };

    Parallel.ForEach(nomes, nome =>
    {
        Console.WriteLine($"Processando Parallel.Foreach {nome} na thread {Task.CurrentId}");
        Task.Delay(500).Wait();
        Console.WriteLine($"Finalizado Parallel.Foreach {nome}");
    });

    Console.WriteLine("Finalizado!");
}
