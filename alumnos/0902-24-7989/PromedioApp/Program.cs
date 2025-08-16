
using System;

class Program
{
    //Funcion estatica MAIN
	static void Main(string[] args)
    {
        Console.WriteLine("Cálculo del promedio de 5 numeros");

        //Almacenando los datos en la siguiente lista llamada lista, esta es de tipo entero
        int[] lista = new int[5];
        int n = 0;
        while (n < 5)
        {
            Console.Write($"Ingrese el número entero #{n + 1}: ");
            string entrada = Console.ReadLine();

            //Validando la entrada de los datos a enteros
            if (int.TryParse(entrada, out int numero))
            {
                lista[n] = numero;
                n++;
            }
            else
            {
                Console.WriteLine("Dato no valido. Ingrese un numero entero.");
            }
        }

        //Imprimiendo el resultado
        double resultado = Promedio(lista);
        Console.WriteLine($"El promedio es: {resultado:F2}");
    }

    //Funcion retornable de promedio
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
