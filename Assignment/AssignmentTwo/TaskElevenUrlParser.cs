namespace Assignment.AssignmentTwo;

public class TaskElevenUrlParser
{
    public void DemoUrlParser()
    {
        Console.WriteLine("Please input the url: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid URL, exiting program");
            return;
        }

        // 3 parts create
        string protocol, server, resource;
        protocol = server = resource = string.Empty; // have to do this to print them at end, else gices not intialzied compile error
        var protocolSplit = input.Split(new[] { "://" }, StringSplitOptions.None);
        if (protocolSplit.Length == 2)
        {
            protocol = protocolSplit[0];
            // put the rest of the string back into input
            input = protocolSplit[1];
        }

        var serverSplit = input.Split(new[] { "/" }, 2, StringSplitOptions.None);

        if (serverSplit.Length >= 1)
        {
            server = serverSplit[0];
        }

        if (serverSplit.Length == 2)
        {
            resource = serverSplit[1];
        }

        // check if server, the mandatory part is valid

        if (string.IsNullOrWhiteSpace(server))
        {
            Console.WriteLine("Server is missing from url, it's invalid.");
            return;
        }

        // print the extracted parts
        Console.WriteLine($@"
Protocol : {protocol}
Server : {server}
Resource : {resource}");
    }
}