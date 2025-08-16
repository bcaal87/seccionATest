using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario ingresar 5 números enteros
        int[] numeros = new int[5];
        
        Console.WriteLine("Ingrese 5 números enteros:");
        
        for (int i = 0; i < 5; i++)
        {
            bool esValido = false;
            while (!esValido)
            {
                Console.Write($"Número {i + 1}: ");
                string input = Console.ReadLine();
                
                // Validar que el dato ingresado sea un entero
                if (int.TryParse(input, out numeros[i]))
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido.");
                }
            }
        }
        
        // Calcular el promedio usando la función Promedio
        double resultado = Promedio(numeros);
        
        // Mostrar el promedio con dos decimales
        Console.WriteLine($"\nEl promedio de los números ingresados es: {resultado:F2}");
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
    
    // Función que recibe el arreglo y devuelve el promedio
    static double Promedio(int[] arreglo)
    {
        double suma = 0;
        
        // Sumar todos los elementos del arreglo
        for (int i = 0; i < arreglo.Length; i++)
        {
            suma += arreglo[i];
        }
        
        // Calcular y devolver el promedio
        return suma / arreglo.Length;
    }
}

