using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int contador = 0;

        while (contador < 5)
        {
            Console.Write($"Ingrese el número entero #{contador + 1}: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor))
            {
                numeros[contador] = valor;
                contador++;
            }
            else
            {
                Console.WriteLine("Dato inválido. Por favor, ingrese un número entero.");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }

    static double Promedio(int[] numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return (double)suma/ numeros.Length;
    }
}