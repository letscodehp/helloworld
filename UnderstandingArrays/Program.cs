using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            */

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            string[] names = new string[] { "Eddie", "Alex", "Michael" };

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);

            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (int number in numbers) {
                Console.WriteLine(number);
            }

            foreach (string name in names) {
                Console.WriteLine(name);
            }

            string zip = "You can get what you want out of life " +
                "if you help enough other people get what they want.";

            char[] charArray = zip.ToCharArray();
            Array.Reverse((charArray));

            foreach(char zigChar in charArray) {
                Console.WriteLine(zigChar);
            }

        }
    }
}
