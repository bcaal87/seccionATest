using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        Console.WriteLine(" Bienvenido al programa de cálculo de promedio");
        Console.WriteLine("Instrucciones:");
        Console.WriteLine("1. Ingrese 5 números enteros.");
        Console.WriteLine("2. Los números se guardarán en un arreglo.");
        Console.WriteLine("3. La función Promedio calculará el resultado.");
        Console.WriteLine("4. Muestre el promedio en pantalla con 2 decimales.\n");



        // Solicita al usuario que ingrese 5 números enteros
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada inválida. Por favor, ingrese un número entero: ");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio:F2}");
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    // Calcula el promedio de los elementos del arreglo
        static double Promedio(int[] numeros)
        {
            double sumaNumeros = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaNumeros += numeros[i];
            }
            return sumaNumeros / numeros.Length;
        }
}
