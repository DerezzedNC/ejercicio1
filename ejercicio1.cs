using System;

class ProgramaSumaPromedio
{
    static void Main()
    {
        int[] numeros = new int[10];
        int suma = 0;

        // Pedir al usuario que ingrese 10 números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i]; // Ir sumando los números
        }

        // Calcular el promedio
        double promedio = suma / 10.0;

        // Mostrar resultados
        Console.WriteLine($"\nSuma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
    }
}
