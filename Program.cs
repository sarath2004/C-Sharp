using System;

namespace C_Sharp_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Console Calculator";
            Console.WriteLine("Welcome to the console calculator v.1.0!");
            Console.WriteLine("Enter a number...");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter another number...");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What do u want to do with the two numbers?\n(1)Add\n(2)Subtract\n(3)Multiply\n(4)Division");
            int userInput = Convert.ToInt16(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine(x + y);
            }
            else if (userInput == 2)
            {
                Console.WriteLine(x - y);
            }
            else if (userInput == 3)
            {
                Console.WriteLine(x * y);
            }
            else if (userInput == 4)
            {
                Console.WriteLine(x / y);
            }


            System.Threading.Thread.Sleep(1000);
        }
    }
}
