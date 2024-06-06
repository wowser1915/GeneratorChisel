using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 11);
            Console.WriteLine($"Случайное число: {randomNumber}");

            Console.ReadLine();
        }
    }
}