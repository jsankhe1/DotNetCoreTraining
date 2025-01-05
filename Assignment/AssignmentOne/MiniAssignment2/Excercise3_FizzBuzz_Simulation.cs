using Assignment.Helpers;

namespace Assignment.MiniAssignment2;
/*1. **FizzBuzz Simulation:**  
Create a console application (`Exercise03`) that simulates a FizzBuzz game up to 100.*/
public class Excercise3FizzBuzzSimulation
{
    public void printFizzBuzz()
    {
        Console.WriteLine("Enter the number up to which we shall calculate fizzbuzz: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        if (limit > 100)
        {
            ConsolePrintingPretty.PrintCenteredMessage("You've  just activated my trap card, we don't take values above 100");
            return;
        }

        for (int i = 1; i <= limit; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write($"FizzBuzz ");
            }
            else if(i % 5 == 0)
            {
                Console.Write($"Buzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write($"Fizz ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();

    }
    
}