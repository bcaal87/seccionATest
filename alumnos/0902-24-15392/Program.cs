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
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))
            {
                numeros[contador] = numero;
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