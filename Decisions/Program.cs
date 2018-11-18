using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            /*
             * Example 1

            string msg;
            
            if (userValue == "1")
                msg = "You won a new car";
            else if (userValue == "2") 
                msg = "You won a new boat";
            else if (userValue == "3")
                msg = "You won a new cat";
            else {
                msg = "Wrong values. ";
                msg += "Try again later";
            }
            Console.WriteLine(msg);
            */

            /*
             * Example 2
            Console.WriteLine("You won a {0}", (userValue == "1") ? "boat" : "car");
            */

            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, (userValue == "1") ? "boat" : "car");

        }
    }
}
