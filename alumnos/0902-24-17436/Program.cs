using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int i = 0;
        while (i < 5)
        {
            Console.Write($"Ingrese el número entero #{i + 1}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                numeros[i] = num;
                i++;
            }
            else
            {
                Console.WriteLine("Dato inválido. Por favor ingrese un número entero.");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }

    static double Promedio(int[] arr)
    {
        int suma = 0;
        foreach (int n in arr)
            suma += n;
        return (double)suma / arr.Length;
    }
}