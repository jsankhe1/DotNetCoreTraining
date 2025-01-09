using System.Text;

namespace Assignment.AssignmentTwo;

public class TaskEightReverseString
{
    public void DemoReverseString()
    
    {
        Console.WriteLine("Please type your string: ");
        string inputString = Console.ReadLine();
        string reversedString = new string(inputString.Reverse().ToArray());
        // string.Revrse() returns an Ienumerable<char>
        // .ToArray() converts it into array of characters
        //new string(char[]) takes the array and creates a string from it.
        
        Console.WriteLine($"Reversed string is {reversedString}");
        // Method 1: Using char array
        string reversedUsingArray = ReverseUsingArray(inputString);
        Console.WriteLine($"Reversed string (using array): {reversedUsingArray}");

        // Method 2: Using for loop
        string reversedUsingLoop = ReverseUsingLoop(inputString);
        Console.WriteLine($"Reversed string (using loop): {reversedUsingLoop}");
    }

    private string ReverseUsingArray(string input)
    {
        // Convert to char array, reverse, and convert back to string
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private string ReverseUsingLoop(string input)
    {
        // Use a for loop to construct the reversed string, used string builder to tesh my uderstanding.
        StringBuilder reversed = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        return reversed.ToString();
    }
}