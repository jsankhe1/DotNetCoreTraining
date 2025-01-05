using Assignment.MiniAssignment1;

namespace Assignment.Helpers;

public class MenuHandler
{
    public static void DisplayMenu()
    {
        Console.WriteLine("\n=== Mini Assignment Menu ===");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Hacker Name Generator");
        Console.WriteLine("2. Number Types Information");
        Console.WriteLine("3. Century Converter");
        Console.WriteLine("========================");
        Console.Write("Enter your choice: ");
    }

    public static void MenuSelection(AssignmentTasks choice)
    {
        switch (choice)
        {
            case AssignmentTasks.Exit:
                Console.WriteLine("Exiting program...");
                break;
            case AssignmentTasks.HackerNameGenerator:
                var generator = new CustomUserNameGenerator();
                generator.GenerateName();
                break;
            case AssignmentTasks.NumberTypesInfo:
                var numberTypesInfo = new NumberTypesInfo();
                numberTypesInfo.PrintNumberTypes();
                break;
            case AssignmentTasks.CenturyConverter:
                var centuryCoverter = new CenturyConverter();
                centuryCoverter.PrintConvertCenturies();
                break;
            
            default: break;
        }
    }
}