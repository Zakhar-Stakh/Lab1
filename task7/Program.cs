using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть температуру:");
        double C = double.Parse(Console.ReadLine());

        double F = (C * 9 / 5) + 32;

        Console.WriteLine($"Температура за Фаренгейтом: {F}");
    }
}