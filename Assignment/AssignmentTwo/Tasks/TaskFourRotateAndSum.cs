namespace Assignment.AssignmentTwo;

public class TaskFourRotateAndSum
{
    public void DemoRotateAndSumArrays()
    {
        // Step 1: Read the input array and k value
        Console.WriteLine("Enter the array (space-separated integers):");
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Enter the number of rotations (k):");
        int k = Convert.ToInt32(Console.ReadLine());

        int n = array.Length;
        int[] sumArray = new int[n];

        // Step 2: Rotate and sum the array
        for (int r = 1; r <= k; r++) // Outer loop for rotations
        {
            int[] rotatedArray = new int[n];

            // Rotate the array to the right by 1 step
            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + 1) % n; // New index after rotation
                rotatedArray[newIndex] = array[i];
            }

            // Print the current rotation and array
            Console.WriteLine($"Rotation {r}: {string.Join(" ", rotatedArray)}");

            // Sum the rotated array into sumArray
            for (int i = 0; i < n; i++)
            {
                sumArray[i] += rotatedArray[i];
            }

            // Update the array for the next rotation
            array = rotatedArray;
        }

        // Step 3: Print the resulting sumArray
        Console.WriteLine("Sum of arrays after rotations:");
        Console.WriteLine(string.Join(" ", sumArray));
    }
}