namespace Assignment.Helpers;

public class PrimeDashboard
{
    public void Run()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            MenuHandler.DisplayMenuPrime();
            string userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, out PrimeAssignment choice))
            {


                // we have a valid choice, lets select options
                MenuHandler.MenuPrimeSelection(choice);
                if (choice == PrimeAssignment.Exit)
                {
                    continueRunning = true;
                    return;
                }
            }


            else
            {
                Console.WriteLine("Wrong input, please try again");
            }


            Console.Clear();
        }
    }
}