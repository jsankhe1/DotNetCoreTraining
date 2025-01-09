namespace Assignment.AssignmentTwo;

public class TaskTwoListManagement
{
    public void DemoList()
    {
        List<string> items = new List<string>();
        bool toExit = false;
        bool listEmpty = false;

        while (!toExit)
        {
            Console.WriteLine("To exit program, type exit");
            Console.WriteLine();
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid command. Please try again.");
                continue; // Skip this iteration if input is invalid
            }

            if (input == "exit")
            {
                toExit = true;
                continue;
            }

            if (input.StartsWith("+"))
            {
                string itemToAdd = input.Split()[1];
                items.Add(itemToAdd);
                Console.WriteLine($"{itemToAdd} was added");
            }
            else if ((input.StartsWith("--")))
            {
                items.Clear();
                Console.WriteLine("List has been cleared");
                listEmpty = true;
            }
            else if (input.StartsWith("-"))
            {
                string itemToAdd = input.Split()[1];
                items.Remove(itemToAdd);
                Console.WriteLine($"{itemToAdd} was removed");
            }
            else
            {
                Console.WriteLine("Incorrect format of command, please try again");
            }

            // Display the list

            if (items.Count == 0)
            {
                Console.WriteLine("{EMPTY}");
            }
            else
            {
                if (listEmpty == false)
                {
                    foreach (string item in items)
                    {
                        Console.WriteLine($"> {item}");
                    }
                }
            }
        }
    }
}

