using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть число:");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть число: ");
        int number2 = int.Parse(Console.ReadLine());

        bool Day = number1 >= 1 && number1 <= 31;
        bool Month = number2 >= 1 && number2 <= 12;

        if (Day && Month)
        {
            Console.WriteLine("Числа можуть бути днем та місяцем.");
        }
        else
        {
            Console.WriteLine("Числа не можуть бути днем та місяцем.");
        }
    }
}