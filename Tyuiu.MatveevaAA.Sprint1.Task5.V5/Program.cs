using Tyuiu.MatveevaAA.Sprint1.Task5.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        {
            Console.Write("Введите положительное вещественное число: ");
            double x;


            while (!double.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.WriteLine("Пожалуйста, введите положительное вещественное число.");
            }

            double fractionalPart = x - Math.Floor(x);

            int d = (int)(fractionalPart * 10);

            d = d % 10;

            Console.WriteLine($"Первая цифра из дробной части числа {x} равна {d}");

            Console.ReadKey();

        }

    }
}