
internal class Program{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");
        short opcoes = short.Parse(Console.ReadLine());

        switch(opcoes)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            default: Menu(); break;
        }
    }

    static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Qual o nome do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string texto = file.ReadToEnd();
            Console.WriteLine(texto);
        }

        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void Editar()
    { 
        Console.Clear();
        Console.WriteLine("Digite o texto abaixo. (ESC para sair");
        Console.WriteLine("---------------------");
        string texto = "";
        
        do
        {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
        }
       
        while(Console.ReadKey().Key !=ConsoleKey.Escape);
        Salvar(texto);
    }

    static void Salvar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(texto);

        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
        Menu();
    }
}
