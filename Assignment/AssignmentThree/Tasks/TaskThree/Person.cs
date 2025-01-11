namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class Person
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<String>? Addresses { get; set; } = new List<string>();
    public override string ToString()
    {
        return base.ToString(); 
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }

    public string getLatestAddress()
    {
        return Addresses.LastOrDefault();
    }

    public List<string> getAllAddresses()
    {
        return Addresses;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"{CalculateAge()}");
    }
    
    

}