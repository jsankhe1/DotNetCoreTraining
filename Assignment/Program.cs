namespace Assignment;
using Assignment.MiniAssignment1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        System.Console.WriteLine("Assignment1:Task1 RUnning below");
        CustomUserNameGenerator customName = new CustomUserNameGenerator();
        customName.GenerateName();
    }
}