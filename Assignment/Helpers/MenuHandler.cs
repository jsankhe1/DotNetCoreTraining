using Assignment.MiniAssignment1;
using Assignment.MiniAssignment2;

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
        Console.WriteLine("4. FizzBuzz Simulation");
        Console.WriteLine("5. Guessing Game");
        Console.WriteLine("6. Print Pyramid");
        Console.WriteLine("7. DaysOld Calculator");
        Console.WriteLine("8. DayRoutine");
        Console.WriteLine("9. Increment Counts");
        
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
            case AssignmentTasks.FizzBuzzSimulator:
                var fizzBuzzSimulator = new Excercise3FizzBuzzSimulation();
                fizzBuzzSimulator.printFizzBuzz();
                break;
            case AssignmentTasks.GuessingGame:
                var guessingClient = new GuessingGame();
                guessingClient.PlayGame();
                break;
            case AssignmentTasks.PrintPyramid:
                var Pyramid = new PyramidPattern();
                Pyramid.printPyramid();
                break;
            case AssignmentTasks.DaysOld:
                var DaysOld = new DaysOldCalculator();
                DaysOld.DaysOldPrinter();
                break;
            case AssignmentTasks.Greting:
                var Greeting = new GreetMeNow();
                Greeting.GreetUser();
                break;
            case AssignmentTasks.Incrementer:
                var Incrementer = new IncrementPrinter();
                Incrementer.PrintIncrements();
                break;
            
            default: break;
        }
    }
}