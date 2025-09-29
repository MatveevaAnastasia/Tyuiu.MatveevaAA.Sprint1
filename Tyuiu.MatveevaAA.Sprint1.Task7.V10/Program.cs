using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double z = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Результат: {0:F3}", z);

        Console.ReadKey();
    }
}