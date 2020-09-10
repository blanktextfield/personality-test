using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            int Number;
            Console.WriteLine("what is your number?");
            UserInput = Console.ReadLine();
            Number = Int32.Parse(UserInput);
            if (Number < 0)
            {
                Console.WriteLine($"the provided number is negative");
            }
            else if (Number > 0)
            {
                Console.WriteLine($"the provided number is positive");
            } else
            {
                Console.WriteLine("The number is 0");
            }

        }
    }
}
