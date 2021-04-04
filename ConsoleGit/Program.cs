using System;

namespace ConsoleGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //made comments on GitHub
        }

        int add(int a, int b)
        {
            return a + b;
        }


        int sub(int a, int b)
        {
            return a - b;
        }

        int exp(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
                result *= a;
            return result;
        }
    }
}
