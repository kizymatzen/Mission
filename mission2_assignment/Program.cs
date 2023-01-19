using System;

namespace mission2_assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Display Welcome message
            Console.WriteLine("Welcome to the dice throwing simulator!");
            //Declare array with size of 13
            int[] totals = new int[13];
            //Declare variable to keep track of rolls
            int rolls;

            //Prompt user to enter number of rolls
            Console.Write("How many dice rolls would you like to simulate? ");

            //Convert "rolls" string to integer
            rolls = int.Parse(Console.ReadLine());

            //Create class for random numbers
            Random noRand = new Random();

            //Simulate the rolling of the dice
            for (int i = 0; i < rolls; i++)
            {
                //Generate a random number between 1 and 6 for each die
                int die1 = noRand.Next(1, 7);
                int die2 = noRand.Next(1, 7);
                //Add dice values together
                int total = die1 + die2;
                //Increment corresponding element of totals array
                totals[total]++;
            }

            //Distplay the simulation result header
            Console.WriteLine("DICE ROLLING SIMULLATION RESULTSS");
            //Display message that each "*" represents 1% of the total number of rolls
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            //Display the total number of rolls
            Console.WriteLine("Total number of rolls = " + rolls + ".");

            //Calculate percentage of total rolls and print "*" to represent them
            for (int i = 2; i <= 12; i++)
            {
                double percentage = ((double)totals[i] / rolls) * 100;
                percentage = Math.Round(percentage, 2);
                Console.Write(i + ": ");
                Console.Write(new string('*', (int)percentage));
                Console.WriteLine();
            }
            //Display thank you message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}

