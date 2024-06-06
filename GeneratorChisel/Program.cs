using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next();
        Console.WriteLine("Случайное число: " + randomNumber);
    }
}
