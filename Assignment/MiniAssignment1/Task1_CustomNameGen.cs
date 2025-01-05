namespace Assignment.MiniAssignment1;
class CustomUserNameGenerator
{
    private static Random random;
    public CustomUserNameGenerator()
    {
        random = new Random();
    }

    public string? Color { get; set; }
    public string? Noun { get; set; }
    private string? _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    

    private int randomInt;
    
    public int RandomInt
    {
        get { return randomInt; }
        set { randomInt = value; }
    }
    

    private void GenerateRandomInt() {
        randomInt = random.Next(0,999);
    }
    
    public void GenerateName()
    {
        Console.WriteLine("Enter Color: ");
        Color = Console.ReadLine();
        Console.WriteLine("Enter Noun: ");
        Noun = Console.ReadLine();
        GenerateRandomInt();

        _name =  $"Your Hacker Name is {Color}{Noun}{randomInt}";
        Console.WriteLine(_name);
    }




}