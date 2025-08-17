using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio de Promedio ===");
        Console.WriteLine("Instrucciones:");
        Console.WriteLine("1. Ingrese 5 números enteros.");
        Console.WriteLine("2. Los números se guardarán en un arreglo.");
        Console.WriteLine("3. La función Promedio calculará el resultado.");
        Console.WriteLine("4. Muestre el promedio en pantalla con 2 decimales.\n");

        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número #{i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine()!); // asume entrada válida
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"\nPromedio: {promedio:F2}");
    }

    // Calcula el promedio de los elementos del arreglo
    static double Promedio(int[] numeros)
    {
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }
        return (double)suma / numeros.Length;
    }
}
