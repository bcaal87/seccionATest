using System;

namespace PromedioApp
{
    class Program
    {
        static void Main()
        {
            // solicitar al usuario 5 numeros
            Console.WriteLine("Ingrese 5 números para calcular su promedio:");
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write($"Número {i + 1}: ");
                    string entrada = Console.ReadLine() ?? string.Empty;
                    // Validar que sea entero y no decimal
                    if (int.TryParse(entrada, out int valor))
                    {
                        numeros[i] = valor;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Solo se permiten números enteros (sin letras ni decimales).");
                    }
                }
            }
            double promedio = Promedio(numeros);
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }

        static double Promedio(int[] numeros)
        {
            int suma = 0;
            foreach (int n in numeros)
            {
                suma += n;
            }
            return suma / 5.0;
        }
    }
}
