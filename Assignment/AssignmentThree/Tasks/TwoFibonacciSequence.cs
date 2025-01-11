namespace Assignment.AssignmentThree.Tasks;

public class TwoFibonacciSequence
{


    public void Run()
    {
        Console.WriteLine("Printing First Ten Numbers of the sequence");
        for (int i = 1; i <= 10; i++)
        {
            int fibNumber = RecursiveFib(i);
            Console.WriteLine($"Fibonacci({i}) : {fibNumber}");
        }
        
    }

    public int RecursiveFib(int number)
    {
        // BaseCase
        if (number == 1 || number == 2)
        {
            return 1;
        }
        else
        {
            return RecursiveFib(number - 1) + RecursiveFib(number - 2);
        }
    }
}