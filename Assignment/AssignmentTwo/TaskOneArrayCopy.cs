namespace Assignment.AssignmentTwo;

public class TaskOneArrayCopy
{
    public void DemoCopyArrays()
    {
        Console.WriteLine("Creating an int array of size 10.....");
        int[] arrayOne = {5, 4, 3, 2, 1,10,9,8,7,6};
        Console.WriteLine($"{arrayOne.ToString()} -> {string.Join(",", arrayOne)}");
        Console.WriteLine("Array Created!");
        Console.WriteLine("Creating a second empty array (arrayCopy), size is set to arrayOne.Length");
        int[] arrayCopy = new int[arrayOne.Length];
        Console.WriteLine($"{arrayCopy.ToString()} -> {string.Join(",", arrayCopy)}");

        Console.WriteLine("Copying from arrayOne to arrayCopy in process.......");
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayCopy[i] = arrayOne[i];
        }

        Console.WriteLine("Copied Successfully, printing both");
        Console.WriteLine($"arrayOne -> {arrayOne.ToString()} -> {string.Join(",", arrayOne)}");
        Console.WriteLine($"arrayCopy -> {arrayCopy.ToString()} -> {string.Join(",", arrayCopy)}");
        
        


    }
}