// Proyecto de parcial 1

//Console.WriteLine("Hello, World!");
using System;

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        Console.WriteLine("BIENVENIDO. \n Ingrese 5 números enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.Write($"Número {i + 1}: ");
                string entrada = Console.ReadLine();

                // Validar si la entrada es un número entero
                if (int.TryParse(entrada, out int numero))
                {
                    numeros[i] = numero;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Solo se permiten números enteros. Intente de nuevo.");
                }
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }

    // Función que calcula el promedio
    static double Promedio(int[] arreglo)
    {
        int suma = 0;
        foreach (int numero in arreglo)
        {
            suma += numero;
        }
        return (double)suma / arreglo.Length;
    }
}
