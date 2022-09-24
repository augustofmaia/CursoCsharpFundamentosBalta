using System.Text;
internal class Editor
{
    public static void Show() 
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------");
        Start();
    }


    public static void Start() 
    {
        var arquivo = new StringBuilder();

        do{
            arquivo.Append(Console.ReadLine());
            arquivo.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("--------------------------");
        Console.WriteLine("-Deseja salvar o arquivo? (1 - SIM) (4 - NÃO");
        Visualisar.Show(arquivo.ToString());
        

    }








}