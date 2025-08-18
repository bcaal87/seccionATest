using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        
        Console.WriteLine("------------BIENVENIDO A LA CALCULADORA DE PROMEDIO------------");
        Console.WriteLine("Ingresa 5 numeros:");


        for (int i = 0; i < 5; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.Write($"Número {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num))
                {
                    numeros[i] = num;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Recuerda que solo pude ingresar numeros");
                }
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"\nEl primedio de tus notas es: {promedio:F2}");
    }

    static double Promedio(int[] numeros)
    {
        int suma = 0;
        foreach (int n in numeros)
        {
            suma += n;
        }
        return (double)suma / numeros.Length;
    }
}