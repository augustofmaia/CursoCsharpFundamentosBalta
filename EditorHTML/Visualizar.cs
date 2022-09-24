using System.Text.RegularExpressions; 
internal class Visualisar
{
    public static void Show(string texto)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO VISUALIZAR");
        Console.WriteLine("---------------");
        Subistituir(texto);
        Console.WriteLine("---------------");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Subistituir(string texto)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var palavra = texto.Split(' ');

        for(var i = 0; i < palavra.Length; i++)
        {
            if(strong.IsMatch(palavra[i]))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    palavra[i].Substring(
                        palavra[i].IndexOf('>') + 1,
                        (   
                            (palavra[i].LastIndexOf('<') -1) -
                            palavra[i].IndexOf('>')
                        )
                    )
                );
                Console.Write(" ");
            }

            else {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(palavra[i]);
                Console.Write(" ");
            }
        }
    }
}