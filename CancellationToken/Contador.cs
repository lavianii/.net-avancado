using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancellationToken
{
    public class Contador
    {
        private readonly CancellationTokenSource _tokenSource;

        public Contador()
        {
            _tokenSource = new CancellationTokenSource();
        }

        public async Task IniciarContagemAsync(int contador)
        {
            Console.WriteLine("Contagem iniciada!");

            try
            {
                for (int i = 0; i < contador; i++)
                {
                    if (i == 10)
                    {
                        Console.WriteLine("Deseja continuar a contagem? (sim/nao)");
                        string opc = Console.ReadLine();
                        bool continuar = RetornaTruOuFalse(opc);

                        if (!continuar)
                        {
                            await _tokenSource.CancelAsync();
                        }

                        if (_tokenSource.Token.IsCancellationRequested)
                        {
                            Console.WriteLine("Contagem cancelada");
                            break;
                        }
                    }

                    await Task.Delay(300, _tokenSource.Token);
                    Console.WriteLine("Contagem {0}", i + 1);
                }
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Execução finalizada devido ao cancelamento da tarefa.");
            }
        }

        private static bool RetornaTruOuFalse(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
                switch (texto)
                {
                    case "sim":
                        return true;
                    case "nao":
                        return false;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, responda com 'sim' ou 'nao'.");
                        break;
                }
            }
            return false;
        }
    }

}
