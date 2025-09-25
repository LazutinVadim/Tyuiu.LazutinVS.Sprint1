using Tyuiu.LazutinVS.Sprint1.Task2.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Лазутин В. С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                              *");
        Console.WriteLine("* Выполнил: Лазутин В. С.    | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу которая вычисляет выражение x*y*(5 - x)   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.CalculateRectangleSquare(x, y));

        Console.ReadLine();
    }
}