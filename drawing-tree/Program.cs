using System;

namespace drawing_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uInput = new UserInput();
            var d = new Drawing();

            int numberOfFloors = 0;

            numberOfFloors = uInput.GetNumber(numberOfFloors);
            if (numberOfFloors <= 0)
            {
                Console.WriteLine("Invalid input. Please try again! ");
            }
            else
            {
                d.DrawTree(numberOfFloors);
            }

            Console.WriteLine("\npress any key to exit the process...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
