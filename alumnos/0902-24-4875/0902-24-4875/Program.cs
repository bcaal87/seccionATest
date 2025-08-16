using System;
//this code by for Rony-Soc 2025 
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número entero #{i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
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