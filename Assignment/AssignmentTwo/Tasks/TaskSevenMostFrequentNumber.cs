namespace Assignment.AssignmentTwo;

public class TaskSevenMostFrequentNumber
{
    
    public void DemoMostFrequentNumber()
    {
        // Step 1: Read the input array
        // Refactored code, adding try catch finally
        int[] array = null;
        while (array == null)
        try
        {
            Console.WriteLine("Enter the array (space-separated integers):");
            string[] input = Console.ReadLine().Split(' ');

            // Validate and convert input to an integer array
            array = Array.ConvertAll(input, int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter space-separated integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        int mostFrequentNumber = array[0];
        int maxFrequency = 0;

        foreach (int num in array)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }

            // else add it to the map
            else
            {
                frequencyMap[num] = 1;
            }

            if (frequencyMap[num] > maxFrequency)
            {
                // ensures the very first (leftmost) num is used to as mostFrequent
                maxFrequency = frequencyMap[num];
                mostFrequentNumber = num;
            }
        }

       
        // Step 5: Print the result
        Console.WriteLine($"The number {mostFrequentNumber} is the most frequent ({maxFrequency} times)");
    }

}

