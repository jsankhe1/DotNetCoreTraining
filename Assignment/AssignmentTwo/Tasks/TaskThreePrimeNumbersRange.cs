namespace Assignment.AssignmentTwo;

public class TaskThreePrimeNumbersRange
{
    public void PrimeNumberPrinter()
    {
        int startNum, endNum;
        Console.WriteLine("Please enter StartNum: ");
        startNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter EndNum: ");
        endNum = Convert.ToInt32(Console.ReadLine());

        var result = FindPrimesInRange(startNum, endNum);
        Console.WriteLine(string.Join(",", result));

    }
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        bool isPrime = true;
        for (int num = startNum; num <= endNum; num++)
        {
            isPrime = true;
            {
                for (int j = 2; j <= Math.Sqrt(num); j++ )
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(num);
                }
            }

        }
        Console.WriteLine("prime numbers in range are:");
        return result.ToArray();
    }
}