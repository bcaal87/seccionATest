
using System;

namespace PromedioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            Console.WriteLine("Ingrese 5 números enteros:");

            for (int i = 0; i < 5; i++)
            {
                bool valido = false;
                while (!valido)
                {
                    Console.Write($"Número {i + 1}: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int num))
                    {
                        numeros[i] = num;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Dato inválido. Intenta de nuevo.");
                    }
                }
            }

            double promedio = CalcularPromedio(numeros);
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }

        static double CalcularPromedio(int[] arreglo)
        {
            int suma = 0;
            foreach (int num in arreglo)
            {
                suma += num;
            }
            return (double)suma / arreglo.Length;
        }
    }
}
