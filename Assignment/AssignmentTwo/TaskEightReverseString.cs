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
    }
}