using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть дійсне число:");
        double number = double.Parse(Console.ReadLine());

        double fractionalPart = number * 100;
        int digits = (int)(fractionalPart % 100);

        int digit1 = digits / 10;
        int digit2 = digits % 10;

        Console.WriteLine($"{digit1} + {digit2} = {digit1 + digit2}");
    }
}
