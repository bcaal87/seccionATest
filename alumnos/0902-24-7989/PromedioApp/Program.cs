

int[] numeros = new int[5];

// Solicitar los números al usuario
for (int i = 0; i < 5; i++)
{
    bool numeroValido = false;
    while (!numeroValido)
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        string? entrada = Console.ReadLine();
        
        if (int.TryParse(entrada, out numeros[i]))
        {
            numeroValido = true;
        }
        else
        {
            Console.WriteLine("Por favor ingrese un número entero válido.");
        }
    }
}

// Calcular y mostrar el promedio
double promedio = Promedio(numeros);
Console.WriteLine($"\nEl promedio es: {promedio:F2}");

// Función para calcular el promedio
static double Promedio(int[] nums)
{
    int suma = 0;
    foreach (int num in nums)
    {
        suma += num;
    }
    return (double)suma / nums.Length;
}