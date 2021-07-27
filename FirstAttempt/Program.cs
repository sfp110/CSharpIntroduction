using System;

namespace FirstAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 100;
            x += 10;

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(x);
                x += i;
            }

            Console.WriteLine("Writing out command line arguments");

            foreach(string item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
