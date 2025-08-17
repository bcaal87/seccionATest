using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Promedio de 5 números enteros");

        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int valor))
                {
                    numeros[i] = valor; // guardamos en el arreglo
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            }
        }

        double prom = Promedio(numeros);
        Console.WriteLine($"El promedio es: {prom.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    static double Promedio(int[] numeros)
    {
        long suma = 0;
        foreach (int x in numeros) suma += x;
        return (double)suma / numeros.Length;
    }
}
