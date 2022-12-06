using System;

namespace MultiVerse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World MASTER Local!");

            Console.WriteLine(calculAddition(1, 1));
        }

        static int calculAddition(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
