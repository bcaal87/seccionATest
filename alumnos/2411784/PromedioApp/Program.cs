using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio de Promedio ===");
        Console.WriteLine("Instrucciones:");
        Console.WriteLine("1. Ingrese 5 números enteros..");
        Console.WriteLine("2. Los números se guardarán en un arreglo.");
        Console.WriteLine("3. La función Promedio calculará el resultado.");
        Console.WriteLine("4. Muestre el promedio en pantalla con 2 decimales.");
        Console.WriteLine();

        // Solicite al usuario ingresar 5 números enteros.
        // Guarde los valores en un arreglo.
        int[] numeros = new int[5];
        int contador = 0;

        while (contador < 5)
        {
            Console.Write($"Ingrese el número {contador + 1}: ");
            string? entrada = Console.ReadLine();

            // Verifique si la entrada es nula.
            if (entrada == null)
            {
                Console.WriteLine("⚠️ Error: Entrada nula detectada.");
                continue;
            }

            // Valide que los datos ingresados sean enteros.
            if (int.TryParse(entrada, out int numero))
            {
                numeros[contador] = numero;
                contador++;
            }
            else
            {
                Console.WriteLine("⚠️ Error: Por favor ingrese un número entero válido.");
            }
        }

        // Use una función llamada Promedio que reciba el arreglo
        // y devuelva el promedio de los números.
        double resultado = Promedio(numeros);

        // Muestre en pantalla el promedio con dos decimales.
        Console.WriteLine($"\n✅ El promedio es: {resultado:F2}");
    }

    // Función Promedio que recibe un arreglo y devuelve el promedio.
    static double Promedio(int[] numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return (double)suma / numeros.Length;
    }
}