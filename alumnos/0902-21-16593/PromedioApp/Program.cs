//Calculadora de promedios
using System;
using Microsoft.VisualBasic;

internal class PromedioProgram
{
    //creamos la funcion promedio
    static void Main(string[] args)
    {
        // Creamos un arreglo de tamaño 5 para almacenar los números
        int[] numeros = new int[5];
        // Mensaje de bienvenida al usuario
        Console.WriteLine("Bienvenidos a la calculadora de Promedio");
        // Le damos las instrucciones al usuario para ingresar la información
        Console.WriteLine("Deberá de ingresar 5 números enteros.");
        Console.WriteLine("Luego que ingrese los datos solicitados el sistema calculara el promedio de los números que ha ingresado.");
        Console.WriteLine("Ingrese 5 números enteros.\n");

        // Le pedimos al usuario los 5 números enteros
        for (int i = 0; i < numeros.Length; i++)
        {
            int valor;
            bool valido;

            // Validamos que el valor ingresado por el usuario haya sido un número entero
            do
            {
                Console.Write($"Número {i + 1}: ");
                valido = int.TryParse(Console.ReadLine(), out valor);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Error: Debe ingresar un número entero válido.");
                }

            } while (!valido);

            // Guardamos el valor que el usuario ingreso en el arreglo
            numeros[i] = valor;
        }

        // Calculamos el promedio con la función que creamos
        double promedio = Promedio(numeros);

        // Le mostramos el resultado con dos decimales al usuario
        Console.WriteLine($"\n✅ El promedio de los números ingresados es: {promedio:F2}");
    }

    static double Promedio(int[] array)
    {
        int suma = 0;

        // Sumamos todos los valores ingresados
        foreach (int num in array)
        {
            suma += num;
        }

        // Calculamos el promedio el promedio de todo
        return (double)suma / array.Length;
    }
}