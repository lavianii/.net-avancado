using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    public class Operacoes
    {
        protected Operacoes() { }

        public static async Task IncrementoAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Número: {i + 1}");
                    Task.Delay(500).Wait();
                }

                Console.WriteLine($"Incremento finalizado.");
            });
        }

        public static async Task DecrementoAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"Reduzindo: {i}");
                    Task.Delay(500).Wait();
                }

                Console.WriteLine($"Decremento finalizado.");
            });
        }

        public static void Incremento()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número: {i + 1}");
                Task.Delay(500).Wait();
            }
            
            Console.WriteLine($"Incremento finalizado.");
        }

        public static void Decremento()
        {   
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Reduzindo: {i}");
                Task.Delay(500).Wait();
            }
            
            Console.WriteLine($"Decremento finalizado.");
        }
    }
}
