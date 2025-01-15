namespace Assignment.Helpers.Dashboards;

public abstract class GenericDashboard<TEnum> where TEnum : struct, Enum
{
    private Action<TEnum> _menuSelectionChoiceAction;

    protected GenericDashboard(Action<TEnum> menuSelectionChoiceAction)
    {
        _menuSelectionChoiceAction = menuSelectionChoiceAction;
    }


    public void Run()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            MenuHandler.DisplayMenu<TEnum>();
            string userInput = Console.ReadLine();
            // try to parse enum
            if (Enum.TryParse(userInput, out TEnum choice))
            {
                // Tryparse returns bool, out TEnum  will be assigned the value if bool is True,
                // That's why we have another if, if true, choice has a value we want to check
                if (choice.Equals(Enum.Parse(typeof(TEnum), "Exit")))
                {
                    continueRunning = false;
                    continue;
                }

                _menuSelectionChoiceAction(choice);
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