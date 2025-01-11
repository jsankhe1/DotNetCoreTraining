namespace Assignment.AssignmentThree.Tasks;

public class OneArrayGenerationReversal
{
    private static Random? randomNumGenerator;

    public void Run()
    {
        Console.WriteLine("Enter the size of random Array you want: ");
        string input = Console.ReadLine();
        int parsedlength;
        while (!int.TryParse(input, out parsedlength) || parsedlength <= 0)
        {
            Console.WriteLine("Invalid input, please enter a number greater than 0 ");
            input = Console.ReadLine();
        }

        var generatedArray = GenerateNumbers(parsedlength);
        Reverse(generatedArray);
        PrintNumbers(generatedArray);
    }

    public int[] GenerateNumbers(int length)
    {
        int[] generatedArray = new int[length];
        randomNumGenerator = new Random();


        for (int i = 0; i < length; i++)
        {
            generatedArray[i] = randomNumGenerator.Next(0, length + 1);
        }

        Console.WriteLine($"Generate Array: \n{string.Join(' ', generatedArray)}");

        return generatedArray;
    }

    public void Reverse(int[] numbersArray)
    {
        int end = numbersArray.Length - 1;
        // have to reverse using for loop
        int temp = 0;
        for (int i = 0; i < (numbersArray.Length / 2); i++)
        {
            int last = end - i;
            temp = numbersArray[i];
            numbersArray[i] = numbersArray[last];
            numbersArray[last] = temp;
        }
    }

    public void PrintNumbers(int[] numbersArray)
    {
        Console.WriteLine($"Reversed Array:\n");
        foreach (int num in numbersArray)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
    }
}