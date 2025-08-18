//Aca inicia mi codigo

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese un numero entero: #{i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Error. Por favor iIngrese un número entero: ");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El resultado del promedio es: #{promedio:F2}");
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

