// Program.cs
// Proyecto de parcial 1 
// sacrab Brayan

using System;

class Program
{
    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("Bienvenido al programa de cálculo de promedio.");
        Console.WriteLine("Por favor, ingrese 5 números enteros para calcular el promedio.\n");
        // Crear un arreglo para almacenar 5 números enteros
        // y un contador para controlar la entrada de datos
        int[] numeros = new int[5];
        int contador = 0;

        while (contador < 5)
        {
            // Solicitar al usuario que ingrese un número entero
            // Validar la entrada y almacenar el número en el arreglo
            Console.Write($"Ingrese el valor entero#{contador + 1}: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor))
            {
                numeros[contador] = valor;
                contador++;
            }
            else
            {
                Console.WriteLine("Dato incorreto. Por favor, ingrese un número entero.");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"tu promedio es de: {promedio:F2}");
    }

    static double Promedio(int[] numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return (double)suma / numeros.Length;
    }

}
