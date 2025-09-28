using Tyuiu.MatveevaAA.Sprint1.Task4.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x, y;

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" 1 / sqrt( x + y * 2) = " + ds.Calculate(x, y));

        Console.ReadKey();


    }
}