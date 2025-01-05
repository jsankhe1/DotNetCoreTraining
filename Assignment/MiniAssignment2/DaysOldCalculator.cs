namespace Assignment.MiniAssignment2;
// Write a simple program that defines a variable representing a birth date and calculates 
// how many days old the person with that birth date is currently. 
// For extra credit, output the date of their next 10,000 day (about 27 years) 
// anniversary. Note: once you figure out their age in days, 
// you can calculate the days until the next anniversary using 
// int daysToNextAnniversary = 10000 - (days % 10000); •
public class DaysOldCalculator
{
    public void DaysOldPrinter()
    {
        System.Console.WriteLine("Enter your date of birth in yyyy-mm-dd");
        DateTime birthDate;
        if (!DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            Console.WriteLine("Incorrect Format, please try again later");
            return;
        }

        DateTime today = DateTime.Now;
        TimeSpan yearsGap = today - birthDate;
        int ageInDays = (int)yearsGap.TotalDays;
        Console.WriteLine($"You are {ageInDays} days old.");
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

        Console.WriteLine($"Your next 10,000 day anniversary is on {nextAnniversary.ToString("yyyy-MM-dd")}");
    }

}

