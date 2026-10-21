using System;

class Program
{
    static string CheckNumber(int number)
    {
        if (number > 0)
        {
            return "El número es positivo";
        }
        else if (number < 0)
        {
            return "El número es negativo";
        }
        else
        {
            return "El número es cero";
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Verificador de números ===");
        Console.Write("Ingresa un número entero: ");

        string entrada = Console.ReadLine() ?? "";

        int numero;

        while (!int.TryParse(entrada, out numero))
        {
            Console.Write("Entrada inválida. Ingresa un número entero: ");
            entrada = Console.ReadLine() ?? "";
        }

        string resultado = CheckNumber(numero);

        Console.WriteLine(resultado);
    }
}