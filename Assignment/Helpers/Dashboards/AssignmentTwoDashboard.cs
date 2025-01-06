namespace Assignment.Helpers;

public class AssignmentTwoDashboard
{
    public AssignmentTwoDashboard()
    {
        
    }

    public void Run()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            MenuHandler.DisplayMenuTwo();
            string userInput = Console.ReadLine();
            // try to parse enum
            if (Enum.TryParse(userInput, out AssignmentTwoTasks choice))
                // Tryparse returns bool, out Assignemnt Tasks will be assigned the value if bool is True,
                // That's why we have another if, if true, choice has a value we want to check
            {
   
                // We have a valid choice, let's pass it to menuSelection
                MenuHandler.MenuTwoSelection(choice);
                if (choice == AssignmentTwoTasks.Exit)
                {
                    continueRunning = false;
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
            }
            
            // one run ofmenu selection done, now let user continue
            // one run of menu selection done, now let user continue
            Console.WriteLine("Please Press Any Key to Continue");
            Console.ReadKey();

            Console.Clear();
        }
    }
}