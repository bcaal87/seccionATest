using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese 5 números enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.Write($"Número {i + 1}: ");
                string entrada = Console.ReadLine();

                // Validar que sea un entero
                if (int.TryParse(entrada, out int numero))
                {
                    numeros[i] = numero;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                }
            }
        }

        // Calcular promedio usando la función
        double prom = Promedio(numeros);

        // Mostrar resultado con 2 decimales
        Console.WriteLine($"El promedio es: {prom:F2}");
    }

    // Función que recibe un arreglo y devuelve el promedio
    static double Promedio(int[] arreglo)
    {
        double suma = 0;
        foreach (int num in arreglo)
        {
            suma += num;
        }
        return suma / arreglo.Length;
    }
}
