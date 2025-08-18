//parcialomar
//Programa que lee 5 números enteros, calcula y muestra su promedio.
//Si el usuario ingresa un valor no numérico, muestra un mensaje de error y solicita nuevamente el número.
//Autor: Omar Caal :3


using System; 
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int contador = 0;

        Console.WriteLine("Ingrese 5 números enteros:");

        while (contador < 5)
        {
            Console.Write($"Número {contador + 1}: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int valor))
            {
                numeros[contador] = valor;
                contador++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }

        double promedio = Promedio(numeros);
        Console.WriteLine($"\n El promedio es: {promedio:F2}");
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
