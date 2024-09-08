using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть годину (0-23): ");
        int h = int.Parse(Console.ReadLine());

        if (h >= 4 && h < 11)
        {
            Console.WriteLine("Доброго ранку!");
        }
        else if (h >= 11 && h < 17)
        {
            Console.WriteLine("Добрий день!");
        }
        else if (h >= 17 && h < 23)
        {
            Console.WriteLine("Добрий вечір!");
        }
        else if ((h >= 23 && h < 24) || (h >= 0 && h < 4))
        {
            Console.WriteLine("Доброї ночі!");
        }
        else
        {
            Console.WriteLine("День стільки не триває");
        }
    }
}