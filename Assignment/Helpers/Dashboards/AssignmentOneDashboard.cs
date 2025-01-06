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
            MenuHandler.DisplayMenuOne();
            string userInput = Console.ReadLine();
            // try to parse enum
            if (Enum.TryParse(userInput, out AssignmentOneTasks choice))
                // Tryparse returns bool, out Assignemnt Tasks will be assigned the value if bool is True,
                // That's why we have another if, if true, choice has a value we want to check
            {

                // We have a valid choice, let's pass it to menuSelection
                MenuHandler.MenuOneSelection(choice);
                if (choice == AssignmentOneTasks.Exit)
                {
                    continueRunning = false;
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
            }

            
            // one run of menu selection done, now let user continue
            Console.WriteLine("Please Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}