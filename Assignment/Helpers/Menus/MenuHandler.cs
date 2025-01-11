using Assignment.AssignmentThree.Tasks;
using Assignment.AssignmentThree.Tasks.TaskThree;
using Assignment.AssignmentTwo;
using Assignment.Helpers.Dashboards;
using Assignment.Helpers.Enums;
using Assignment.MiniAssignment1;
using Assignment.MiniAssignment2;

namespace Assignment.Helpers;

public class MenuHandler
{


    public static void DisplayMenuPrime()
    {
        Console.WriteLine("\n===  Assignment Selection Menu ===");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Assignment One Solutions");
        Console.WriteLine("2. Assignment Two Solutions");
        Console.WriteLine("3. Assignment Three Solutions");

        Console.WriteLine("========================");
        Console.Write("Enter your choice: ");
    }

    public static void DisplayMenuOne()
    {
        Console.WriteLine("\n=== Mini Assignment Menu ===");
        Console.WriteLine("0. Return to Main Menu");
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

    public static void DisplayMenuTwo()
    {
        Console.WriteLine("\n=== Mini Assignment Menu ===");
        Console.WriteLine("0. Return to Main Menu");
        Console.WriteLine("1. Array Copy");
        Console.WriteLine("2. List Management");
        Console.WriteLine("3. Prime Print");
        Console.WriteLine("4. Rotate and Sum");
        Console.WriteLine("5. Longest Sequence Equal");
        Console.WriteLine("6. Most Frequent Number");
        Console.WriteLine("7. Reverse a String");
        Console.WriteLine("8. Reverse Words");
        Console.WriteLine("9. Extract Palindrome");
        Console.WriteLine("10. URL Parser");
        Console.WriteLine("========================");
        Console.Write("Enter your choice: ");
    }

    public static void DisplayMenuThree()
    {
        Console.WriteLine("\n=== Mini Assignment Menu ===");
        Console.WriteLine("0. Return to Main Menu");
        Console.WriteLine("1. Array Generate And Reverse");
        Console.WriteLine("2. Fibionacci Sequence");
        Console.WriteLine("3. Object Oriented Practice");
        Console.WriteLine("4. Color and Ball Tort-eh-fun");
        Console.WriteLine("========================");
        Console.Write("Enter your choice: ");
    }

    public static void MenuPrimeSelection(PrimeAssignment choice)
    {
        switch (choice)
        {
            case PrimeAssignment.Exit:
                Console.WriteLine("Exiting program...");
                return;
            case PrimeAssignment.AssignmentOne:
                var assignmentOneDashboard = new AssignmentOneDashboard();
                assignmentOneDashboard.Run();

                break;

            case PrimeAssignment.AssignmentTwo:
                var assignmentTwoDashboard = new AssignmentTwoDashboard();
                assignmentTwoDashboard.Run();
                break;
            
            case PrimeAssignment.AssignmentThree:
                var assignmentThreeDashboard = new AssignmentThreeDashboard();
                assignmentThreeDashboard.Run();
                break;
                
            default: break;
        }
    }

    public static void MenuOneSelection(AssignmentOneTasks choice)
    {
        switch (choice)
        {
            case AssignmentOneTasks.Exit:
                Console.WriteLine("Exiting program...");
                break;
            case AssignmentOneTasks.HackerNameGenerator:
                var generator = new CustomUserNameGenerator();
                generator.GenerateName();
                break;
            case AssignmentOneTasks.NumberTypesInfo:
                var numberTypesInfo = new NumberTypesInfo();
                numberTypesInfo.PrintNumberTypes();
                break;
            case AssignmentOneTasks.CenturyConverter:
                var centuryCoverter = new CenturyConverter();
                centuryCoverter.PrintConvertCenturies();
                break;
            case AssignmentOneTasks.FizzBuzzSimulator:
                var fizzBuzzSimulator = new Excercise3FizzBuzzSimulation();
                fizzBuzzSimulator.printFizzBuzz();
                break;
            case AssignmentOneTasks.GuessingGame:
                var guessingClient = new GuessingGame();
                guessingClient.PlayGame();
                break;
            case AssignmentOneTasks.PrintPyramid:
                var Pyramid = new PyramidPattern();
                Pyramid.printPyramid();
                break;
            case AssignmentOneTasks.DaysOld:
                var DaysOld = new DaysOldCalculator();
                DaysOld.DaysOldPrinter();
                break;
            case AssignmentOneTasks.Greting:
                var Greeting = new GreetMeNow();
                Greeting.GreetUser();
                break;
            case AssignmentOneTasks.Incrementer:
                var Incrementer = new IncrementPrinter();
                Incrementer.PrintIncrements();
                break;

            default: break;
        }
    }

    public static void MenuTwoSelection(AssignmentTwoTasks choice)
    {
        switch (choice)
        {
            case AssignmentTwoTasks.Exit:
                Console.WriteLine("Exiting program...");
                return;
            case AssignmentTwoTasks.ArrayCopy:
                var taskOne = new TaskOneArrayCopy();
                taskOne.DemoCopyArrays();
                break;

            case AssignmentTwoTasks.ListManagement:
                var taskTwo = new TaskTwoListManagement();
                taskTwo.DemoList();
                break;
            case AssignmentTwoTasks.PrimePrint:
                var taskThree = new TaskThreePrimeNumbersRange();
                taskThree.PrimeNumberPrinter();
                break;
            case AssignmentTwoTasks.RotateAndSum:
                var taskFour = new TaskFourRotateAndSum();
                taskFour.DemoRotateAndSumArrays();
                break;
            case AssignmentTwoTasks.LongestSequenceEqual:
                var taskFive = new TaskFiveLongestEqualSequence();
                taskFive.DemoLongestSequenceOfEqualElements();

                break;

            case AssignmentTwoTasks.MostFreqNum:
                var taskSeven = new TaskSevenMostFrequentNumber();
                taskSeven.DemoMostFrequentNumber();

                break;


            case AssignmentTwoTasks.ReverseAString:
                var taskEight = new TaskEightReverseString();
                taskEight.DemoReverseString();
                ;

                break;
            case AssignmentTwoTasks.ReverseWords:
                Console.WriteLine("To be Implemented, thanks for your patience :D");

                break;


            case AssignmentTwoTasks.ExtractPalindrome:
                var taskTen = new TaskTenPalindromeCheck();
                taskTen.DemoExtractPalindromes();
                break;

            case AssignmentTwoTasks.UrlParser:
                var taskEleven = new TaskElevenUrlParser();
                taskEleven.DemoUrlParser();
                break;
            default: break;
        }
    }

    public static void MenuThreeSelection(AssignmentThreeTasks choice)
    {
        switch (choice)
        {
            case AssignmentThreeTasks.Exit:
                Console.WriteLine("Exiting program...");
                return;
            case AssignmentThreeTasks.ArrayGenerationAndReversal:
                var arrayGenRev = new OneArrayGenerationReversal();
                arrayGenRev.Run();
                break;
            case AssignmentThreeTasks.FibonacciSequence:
                var fibonacci = new TwoFibonacciSequence();
                fibonacci.Run();
                break;
            case AssignmentThreeTasks.ObjectOrientedPractice:
                var oopPractice = new ObjectOrientedPractice();
                oopPractice.Run();
                break;
            case AssignmentThreeTasks.ColorAndBallTorture:
                // var colorAndBall = new ColorAndBallTorture();
                // colorAndBall.Run();
                break;
            default:
                Console.WriteLine("Invalid choice or not implemented yet!");
                break;
        }
    }
}