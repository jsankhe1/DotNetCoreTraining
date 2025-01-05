namespace Assignment.MiniAssignment2;

public class IncrementPrinter
{
    public void PrintIncrements()
    {
        for (int increment = 1; increment <= 4; increment++)
        {
            for (int j = 0; j <= 24; j += increment)
            {
                Console.Write(j);
                if (j + increment <= 24)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}