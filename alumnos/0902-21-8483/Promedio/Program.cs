using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            while (true)
            {
                //Pedimos al usuario que ingrese un número entero
                Console.Write($"Ingrese el número entero #{i + 1}: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int valor))
                {
                    numeros[i] = valor;
                    break;
                }
                else
                {
                    //Si no es valido envia este mensaje
                    Console.WriteLine("Dato inválido. Por favor ingrese un número entero.");
                }
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }

    // Método para calcular el promedio de un arreglo de enteros
    static double Promedio(int[] arreglo)
    {
        int suma = 0;
        foreach (int num in arreglo)
        {
            suma += num;
        }
        return (double)suma / arreglo.Length;
    }

    //fin del programa
}