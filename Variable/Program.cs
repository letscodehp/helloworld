using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 7;
            y = x + 3;

            Console.WriteLine(y);


            Console.WriteLine("First name..: ");
            string myFirstName = Console.ReadLine();

			Console.WriteLine("Last name..: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        }
    }
} 
