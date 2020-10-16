using System;

namespace ProjectAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");

            var name = Console.ReadLine();
            var date = DateTime.Now;

            //Output
            Console.WriteLine($"\n Hello, {name}, on {date:d} at {date:t}!");


            //int x = 10 + 2 * 2;
            //Console.WriteLine(x);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
