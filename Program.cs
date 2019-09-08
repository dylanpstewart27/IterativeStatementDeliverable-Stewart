using System;

namespace IterativeStatementDeliverable_Stewart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer between 1 and 100 to execute an iterative statement");

            try
            {
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if ((value > 0) && (value < 101))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value.ToString() + " times.");

                    for (int i = 0; i < value; i++)
                    {
                        Console.WriteLine("This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please enter an integer value within the stated values and try running the program again ...");
                Console.WriteLine("Press any key to exit the program, thank you for using it!...");
                Console.ReadKey(true);
            }
        }
    }
}
