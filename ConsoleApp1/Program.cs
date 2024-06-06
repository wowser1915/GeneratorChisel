using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное значение диапазона:");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение диапазона:");
            int max = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            int randomNumber = random.Next(min, max + 1);
            Console.WriteLine($"Случайное число: {randomNumber}");

            Console.ReadLine();
        }
    }
}
