namespace Assignment.AssignmentThree.Tasks.TaskFour;

public class CBTask
{
    public void Run()
    {
        var redColor = new Color(255, 0, 0);
        var semiBlueColor = new Color(0, 0, 255, 200);

        var ball1 = new Ball(10, redColor);
        var ball2 = new Ball(15, semiBlueColor);
        var ball3 = new Ball(20, new Color(0, 255, 0));
        
        // Throw balls around
        ball1.Throw();
        ball2.Throw();
        
        ball2.Throw();
        ball2.Throw();
        
        ball1.Throw();
        ball1.Throw();
        ball1.Pop();
        ball1.Throw();
        ball3.Throw();
        
        ball3.Throw();

        Console.WriteLine($"Ball 1 Throw Count: {ball1.TimesThrown} (Popped)");
        Console.WriteLine($"Ball2 Throw Count: {ball2.TimesThrown}");
        Console.WriteLine($"Ball3 Throw Count: {ball3.TimesThrown}");
    }
}