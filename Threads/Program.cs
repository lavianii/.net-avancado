static void DiaNumero()
{
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine("Dia {0} - Thread {1}", i + 1, Environment.CurrentManagedThreadId);
        Thread.Sleep(500);
    }
}
static void ExibirDias()
{
    string[] diasArray = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
    foreach (string dia in diasArray)
    {
        Console.WriteLine("Dia da semana: {0} - Thread {1}", dia, Environment.CurrentManagedThreadId);
        Thread.Sleep(500);
    }
}

Thread t1 = new(DiaNumero);
Thread t2 = new(ExibirDias);

t1.Start();
t2.Start();
string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

foreach(string mes in meses)
{
    Console.WriteLine("(Thread Principal)Mês: {0} - Thread {1}", mes, Environment.CurrentManagedThreadId);
    Thread.Sleep(500);
}
