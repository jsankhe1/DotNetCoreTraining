namespace Assignment.AssignmentThree.Tasks.TaskFour;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }


    public Color(int red, int blue, int green, int alpha)
    {
        Red = red;
        Blue = blue;
        Green = green;
        Alpha = alpha;
    }
    public Color(int red, int blue, int green)
    {
        Alpha = 255;
    }

    public int GetGrayscale()
    {
        return (Red + Blue + Green) / 3;
    }
}