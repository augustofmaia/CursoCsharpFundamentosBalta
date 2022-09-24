internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.Clear();
        Console.WriteLine("S = Segundos (ex: 10s = 10 segundos)");
        Console.WriteLine("M = Minutos (ex: 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string? v = Console.ReadLine();
        string data = v.ToLower();
        char type = char.Parse(data.Substring(data.Length -1,1));
        int tempo = int.Parse(data.Substring(0,data.Length -1));
        int multiplicador = 1;
        
        if (type == 'm')
            multiplicador = 60;

        if (tempo == 0)
            System.Environment.Exit(0);

        PreStart(tempo * multiplicador);
    }

    static void PreStart(int tempo){
        Console.Clear();
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("JÁ!!!!!!");
        Thread.Sleep(500);

        Start(tempo);
    }

    static void Start(int tempo){
        
        int tempoAtual = 0;

        while (tempoAtual != tempo)
        {
            Console.Clear();
            tempoAtual++;
            Console.WriteLine(tempoAtual);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronometro finalizado... retornando para o menu.");
        Thread.Sleep(2500);
        Menu();
    }

}