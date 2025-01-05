namespace Assignment.Helpers;

public class AssignmentOneDashboard
{
    public AssignmentOneDashboard()
    {
        
    }

    public void Run()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            MenuHandler.DisplayMenu();
            string userInput = Console.ReadLine();
            // try to parse enum
            if (Enum.TryParse(userInput, out AssignmentTasks choice))
                // Tryparse returns bool, out Assignemnt Tasks will be assigned the value if bool is True,
                // That's why we have another if, if true, choice has a value we want to check
            {
                if (choice == AssignmentTasks.Exit)
                {
                    continueRunning = false;
                    continue;
                }
                // We have a valid choice, let's pass it to menuSelection
                MenuHandler.MenuSelection(choice);
            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
            }
            
            // one run ofmenu selection done, now let user continue
            Console.WriteLine("press anykey to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}