using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        Console.WriteLine("Ingrese 5 números enteros:");

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write($"Número {i + 1}: ");
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int valor))
                {
                    numeros[i] = valor;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor ingrese un número entero.");
                }
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"\n El promedio es: {promedio:F2}");
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