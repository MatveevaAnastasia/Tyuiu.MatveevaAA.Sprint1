using Tyuiu.MatveevaAA.Sprint1.Task3.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Матвеева А. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Матвеева Анастасия Андреевна | ПКТБ-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите радиус основания цилиндра: ");
        string input1 = Console.ReadLine();

        Console.Write("Введите высоту цилиндра: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double r) &&
        double.TryParse(input2, out double h) &&
        r > 0 && h > 0)
        {
            double square2 = Math.PI * Math.Pow(r * r) * h;
            Console.WriteLine($"Объем цилиндра: {Math.Round(square2, 3)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода: введите положительные числа");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.ReadLine();
    }
}