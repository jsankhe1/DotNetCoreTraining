namespace Assignment.Helpers;

public static class ConsolePrintingPretty
{
    public static void PrintCenteredMessage(string message)
    {
        int consoleWidth = Console.WindowWidth;
        int padding = (consoleWidth - message.Length) / 2;
        string paddedMessage = message.PadLeft(padding + message.Length).PadRight(consoleWidth);
        Console.WriteLine(paddedMessage);
    }
    
}