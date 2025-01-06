namespace Assignment.AssignmentTwo;

public class TaskFiveLongestEqualSequence
{
    public void DemoLongestSequenceOfEqualElements()
    {
        // Step 1: Read the input array
        Console.WriteLine("Enter the array (space-separated integers):");
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);

        // Step 2: Variables to track the longest sequence
        int maxLength = 0;
        int currentLength = 1;
        int startIndexOfMaxSequence = 0;

        // Step 3: Loop through the array to find the longest sequence
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            // Update the maximum sequence if a longer sequence is found
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startIndexOfMaxSequence = i - currentLength + 1;
            }
        }

        // Step 4: Extract the longest sequence from the array
        int[] longestSequence = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            longestSequence[i] = array[startIndexOfMaxSequence + i];
        }

        // Step 5: Print the longest sequence
        Console.WriteLine("Longest sequence of equal elements:");
        Console.WriteLine(string.Join(" ", longestSequence));
    }
}

