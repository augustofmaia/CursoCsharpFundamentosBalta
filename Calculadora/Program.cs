internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.Clear();

        Console.WriteLine("Ola! O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");
        Console.WriteLine("Selecione uma opção: ");
       
        Console.WriteLine("");
        float operacao = float.Parse(Console.ReadLine());
        
        switch(operacao){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: System.Environment.Exit(0); break;
            default : Menu(); break;

        }
    }

    static void Soma() {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor");
        float valor2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = valor1 + valor2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        // Console.WriteLine("O resultado da soma é " + resultado);
        // Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
        // Console.WriteLine($"O resultado da soma é " + (valor1 + valor2));
        Console.WriteLine("");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao() {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 - valor2;
        Console.WriteLine($"O resultado da subtração é {resultado}");

        Console.ReadKey();
        Menu();


    }
    static void Divisao(){
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 / valor2;
        Console.WriteLine($"O valor da divisão é {resultado}");

        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao(){
        Console.Clear();

        Console.WriteLine("Primeiro valor");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 * valor2;
        Console.WriteLine($"O resultadoda multiplicação é {resultado}");

        Console.ReadKey();
        Menu();
    }
}