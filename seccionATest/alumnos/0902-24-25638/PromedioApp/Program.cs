using System;

class Program {
    static void Main() {
        int[] nums = new int[5];
        Console.WriteLine("Ingrese 5 números enteros:");

        for (int i = 0; i < 5; i++) {
            while (true) {
                Console.Write($"Número {i+1}: ");
                if (int.TryParse(Console.ReadLine(), out nums[i])) break;
                Console.WriteLine("¡Error! Debe ser entero.");
            }
        }

        double prom = CalcularPromedio(nums);
        Console.WriteLine($"Promedio: {prom.ToString("0.00")}");
    }

    static double CalcularPromedio(int[] nums) {
        int suma = 0;
        foreach (int num in nums) suma += num;
        return suma / 5.0;  // ¡El .0 es crucial!
    }
}
