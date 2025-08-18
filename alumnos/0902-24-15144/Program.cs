using System;

namespace PromedioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                bool valido = false;
                while (!valido)
                {
                    Console.Write($"Ingrese el número entero #{i + 1}: ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int numero))
                    {
                        numeros[i] = numero;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un número entero válido.");
                    }
                }
            }

            double promedio = Promedio(numeros);
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }

        static double Promedio(int[] arreglo)
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
