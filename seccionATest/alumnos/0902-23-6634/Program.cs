using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Promedio de 5 enteros ===\n");

        int[] numeros = new int[5];

        // 1) Solicitar 5 números enteros y validar que sean enteros
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = LeerEntero($"Ingresa el número entero #{i + 1}: ");
        }

        // 2) Usar una función que recibe el arreglo y devuelve el promedio
        double promedio = Promedio(numeros);

        // 3) Pedir carnet y mostrar lista con carnet al final
        Console.Write("\nIngresa tu carnet (sin espacios): ");
        string carnet = (Console.ReadLine() ?? "").Trim();

        Console.WriteLine("\nNúmeros ingresados:");
        Console.WriteLine("[{0}]", string.Join(", ", numeros));

        Console.WriteLine("Lista con carnet al final:");
        Console.WriteLine("[{0}{1}]",
            string.Join(", ", numeros),
            string.IsNullOrEmpty(carnet) ? "" : $", {carnet}");

        // 4) Mostrar promedio con dos decimales
        Console.WriteLine($"\nPromedio: {promedio:F2}");

        Console.WriteLine("\nFin. Presiona ENTER para salir...");
        Console.ReadLine();
    }

    // Valida que el dato sea entero (si no, vuelve a pedirlo)
    static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int valor))
                return valor;

            Console.WriteLine("⚠️ Debe ser un número ENTERO. Intenta de nuevo.\n");
        }
    }

    // Función solicitada: recibe el arreglo y devuelve el promedio
    static double Promedio(int[] datos)
    {
        long suma = 0;
        foreach (var n in datos) suma += n;
        return datos.Length == 0 ? 0 : (double)suma / datos.Length;
    }
}
