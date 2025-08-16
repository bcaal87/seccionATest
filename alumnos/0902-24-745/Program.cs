using System;

class Program
{
	static void Main(string[] args)
	{
		int[] numeros = new int[5]; //arreglo para almacenar los 5 numeros que se le solicitan al usuario
		int contador = 0; //contador para controlar el ciclo de entrada
		while (contador < 5)
		{
			Console.Write($"Ingrese el número entero {contador + 1}: ");
			string entrada = Console.ReadLine() ?? "";
			if (int.TryParse(entrada, out int numero))
			{
				numeros[contador] = numero; //guarda el numero en el arreglo
				contador++;
			}
			else
			{
				Console.WriteLine("Dato inválido. Por favor ingrese un número entero.");
			}
		}
		double promedio = Promedio(numeros); //llama a la funcion para calcular
		Console.WriteLine($"El promedio es: {promedio:F2}"); //muestra el promedio con dos decimales
	}

	static double Promedio(int[] arreglo)
	{
		int suma = 0;
		foreach (int num in arreglo) //recoge el arreglo y suma los valores 
		{
			suma += num;
		}
		return (double)suma / arreglo.Length; //calcula y devuelve el promedio
	}
}