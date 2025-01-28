using CancellationToken;
using System.Globalization;

Console.WriteLine("Digite um número não negativo e maior que dez:");
int contador;

while (true)
{
    string input = Console.ReadLine();
    if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out contador) && contador > 10)
    {
        break;
    }
    Console.WriteLine("Entrada inválida. Por favor, digite um número maior que dez:");
}

var contadorObj = new Contador();
await contadorObj.IniciarContagemAsync(contador);