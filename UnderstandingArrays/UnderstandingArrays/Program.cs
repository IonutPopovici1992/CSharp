using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1 = 10;
            int number2 = 20;
            int number3 = 30;
            int number4 = 40;
            int number5 = 50;

            if (number1 == 15)
            {
            }
            else if (number2 == 15)
            {
            }
            else if (number3 == 15)
            {
            }
            else
            {
            }
            */

            /*
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            numbers[5] = 60;

            // Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            // int[] numbers = new int[] { 10, 20, 30, 40, 50, 60 };

            // string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
            */

            string zig = "You can get everything in life you want " +
                "if you will just help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
