internal class Menu
{

    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        DesenharTela();
        Escreveropcoes();

        var opcao = short.Parse(Console.ReadLine());
        ManipularOpcaoMenu(opcao);
    }

    public static void DesenharTela()
    {
        
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
            Console.Write("-");
        
        Console.Write("+");
        Console.Write("\n");
        

        for (int linhas = 0; linhas <= 10; linhas++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i <= 30; i++)
            Console.Write("-");
        
        Console.Write("+");
        Console.Write("\n");
            

    }

    public static void Escreveropcoes(){
        Console.SetCursorPosition(3,2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3,3);
        Console.WriteLine("===========");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3,9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3,10);
        Console.Write("Opção:");

    }


    public static void ManipularOpcaoMenu(short opcao)
    {
        switch(opcao) {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("Novo Arquivo"); break;
            case 0: {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: Show(); break;
        }
    }

}


