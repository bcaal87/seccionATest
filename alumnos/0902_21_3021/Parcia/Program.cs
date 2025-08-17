using System;
//Examen Parcial - Program.cs
//Autor: David Carrera Merida
//Fecha: 17/08/2025

class Program
{
    // Función 
    static double Promedio(int[] numeros)
    {
        int suma = 0;
        foreach (int n in numeros)
        {
            suma += n;
        }
        return (double)suma / numeros.Length;
    }

    //Solicitamos los numeros al usuario
    static void Main(string[] args)
    {
        int[] numeros = new int[5];

        Console.WriteLine("Ingrese 5 números  que sean enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            bool esValido = false;
            while (!esValido)
            {
                //Contador para que el usuario sepa cuántos números ha ingresado
                Console.Write($"Número {i + 1}: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int valor))
                {
                    numeros[i] = valor;
                    esValido = true;
                }
                else
                {
                    Console.WriteLine(" solamente debe ingresar un número entero válido.");
                }
            }
        }
        //aca llamamos a la funcion
        double promedio = Promedio(numeros);

        Console.WriteLine($"\nEl promedio de los números ingresados es:  {promedio:F2}");
    }
}
//final 


