using System;
//inicio de programa
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        Console.WriteLine("Ingrese 5 números enteros:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Por favor ingrese un número entero: ");
            }
        }

        double promedio = CalcularPromedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }
//calcular promedio
    static double CalcularPromedio(int[] arreglo)
    {
        int suma = 0;
        foreach (int num in arreglo)
        {
            suma += num;
        }
        return (double)suma / arreglo.Length;
    }
}
//fin de programa