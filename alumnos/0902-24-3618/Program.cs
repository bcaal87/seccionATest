using System;

namespace PromedioApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Promedio de 5 números enteros ===");
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Ingresa el entero #{i + 1}: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int valor))
                    {
                        numeros[i] = valor;      // guarda en el arreglo
                        break;                    // válido: sale del while
                    }

                    Console.WriteLine("Entrada inválida. Debes ingresar un número ENTERO. Intenta de nuevo.");
                }
            }

            double promedio = Promedio(numeros);   // usa la función solicitada
            Console.WriteLine($"Promedio: {promedio:F2}"); // dos decimales
        }

        // recibe el arreglo y devuelve el promedio
        static double Promedio(int[] valores)
        {
            long suma = 0;
            foreach (var v in valores) suma += v;
            return (double)suma / valores.Length;
        }
    }
}
