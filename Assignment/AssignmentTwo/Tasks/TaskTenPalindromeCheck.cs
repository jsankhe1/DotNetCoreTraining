namespace Assignment.AssignmentTwo;

public class TaskTenPalindromeCheck
{
    public void DemoExtractPalindromes()
    {
        Console.WriteLine("Enter a text to extract palindromes:");
        string input = Console.ReadLine();

        // Step 1: Split input into substrings (words) based on spaces
        string[] substrings = input.Split(' ');

        // Step 2: Create a list to store unique palindromes
        HashSet<string> palindromeSet = new HashSet<string>();

        // Step 3: Check each substring for palindrome
        foreach (string substring in substrings)
        {
            string cleanedSubstring = CleanString(substring); // Remove punctuation
            if (IsPalindrome(cleanedSubstring))
            {
                palindromeSet.Add(cleanedSubstring);
            }
        }

        // Step 4: Sort the palindromes
        List<string> sortedPalindromes = new List<string>(palindromeSet);
        sortedPalindromes.Sort(StringComparer.OrdinalIgnoreCase);

        // Step 5: Print the sorted list of palindromes
        Console.WriteLine("Extracted unique palindromes (sorted):");
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    // Method to clean the string by removing punctuation and converting to lowercase
    private string CleanString(string input)
    {
        var cleaned = new List<char>();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleaned.Add(c);
            }
        }
        return new string(cleaned.ToArray());
    }

    // Method to check if a string is a palindrome
    private bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        int left = 0, right = input.Length - 1;
        while (left < right)
        {
            if (input[left] != input[right]) // Compare normalized characters
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}