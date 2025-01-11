namespace Assignment.AssignmentThree.Tasks.TaskThree;

public class Instructor : Person
{
    public decimal Salary { get; private set; }
    public DateTime JoinDate { get; set; }
    

    public Instructor(decimal baseSalary)
    {
        if (baseSalary < 0)
        {
            // default is 1, set by me as placeholder
            baseSalary = 1;
        }

        Salary = baseSalary;
    }

    public override string ToString()
    {
        return base.ToString();
        Console.WriteLine($"JoinDate: {JoinDate.ToString()}");
    }

    public decimal CalculateTotalSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        // 10 modifier added by me, placeholder
        Salary = Salary + (yearsOfExperience * 10);
        return Salary;
    }
}
