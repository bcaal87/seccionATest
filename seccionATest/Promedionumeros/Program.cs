using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número #{i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Ingrese solo numeros enteros: ");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }

    static double Promedio(int[] arr)
    {
        int suma = 0;
        foreach (int num in arr)
        {
            suma += num;
        }
        return (double)suma / arr.Length;
    }
}