namespace Assignment.AssignmentThree.Tasks.TaskFour;

public class Ball
{
    public int Size { get; set; }
    public Color Color { get; set; }

    public int TimesThrown { get; set; }
    public bool HasPopped { get; set; }

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        HasPopped = false;
        TimesThrown = 0;
    }

    public void Pop()
    {
        if (Size == 0)
        {
            Console.WriteLine("It's already dead man, please stop!");
        }
        else
        {
            Size = 0;
            HasPopped = true;
        }
        
    }

    public void Throw()
    {
        if (HasPopped)
        {
            Console.WriteLine("Ball is Popped, can't throw");
        }
        else
        {
            TimesThrown += 1;
        }
        
    }
    
    
    
}