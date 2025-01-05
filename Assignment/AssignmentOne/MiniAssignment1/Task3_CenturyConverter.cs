namespace Assignment.MiniAssignment1;

/*
 2. Write a program to convert centuries into years, days, hours, minutes, seconds, milliseconds, microseconds, and nanoseconds.
- Input: `1`
- Output: `1 century = 100 years = 36524 days = 876576 hours = 52594560 minutes = ...
`*/
public class CenturyConverter
{
    public int Century { get; set; }
    public double Years { get; set; }
    public double Days { get; set; }
    public double Hours { get; set; }
    public double Minutes { get; set; }
    public double Seconds { get; set; }
    public double Miliseconds { get; set; }
    public double Microseconds { get; set; }
    public double Nanoseconds { get; set; }

    public CenturyConverter()
    {
    }

    public void PrintConvertCenturies()
    {
        Console.WriteLine("Enter the number of centuries to see conversion scale: ");
        Century = Convert.ToInt32(Console.ReadLine());
        if (Century <= 0)
        {
            Console.WriteLine("Please provide a positive value, you're going back to menu :)");
            return;
        }
        // Conversion factors
        int yearsInCentury = 100;
        double daysInYear = 365.25; // Accounting for leap years
        int hoursInDay = 24;
        int minutesInHour = 60;
        int secondsInMinute = 60;
        int millisecondsInSecond = 1000;
        int microsecondsInMillisecond = 1000;
        int nanosecondsInMicrosecond = 1000;

        //Converstion now

        Years = Century * yearsInCentury;
        Days = Years * daysInYear;
        Hours = Days * hoursInDay;
        Minutes = Hours * minutesInHour;
        Seconds = Minutes * secondsInMinute;
        Miliseconds = Seconds * millisecondsInSecond;
        Microseconds = Miliseconds * microsecondsInMillisecond;
        Nanoseconds = Microseconds * nanosecondsInMicrosecond;


        Console.WriteLine($@"   {Century} centuries is: 
                                {Years} years
                                {Days} days
                                {Hours} hours
                                {Minutes} minutes
                                {Seconds} seconds
                                {Miliseconds} milliseconds
                                {Microseconds} microseconds
                                {Nanoseconds} nanoseconds
");
    }
}