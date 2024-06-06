using System;

namespace RandomCharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемую длину последовательности:");
            int length = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            string randomString = GenerateRandomString(length);

            Console.WriteLine($"Случайная строка: {randomString}");

            Console.ReadLine();
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }
    }
}