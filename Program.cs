using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);
        int min = Math.Min(a, b);

        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Минимальное число: {min}");

        Console.ReadKey();
    }
}