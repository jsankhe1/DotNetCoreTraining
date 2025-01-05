namespace Assignment.MiniAssignment2;
//    Write a program to greet the user with appropriate messages based on the time of day:
// - "Good Morning"
// - "Good Afternoon"
// - "Good Evening"
// - "Good Night"
//   It's up to you which times should serve as the starting and ending ranges for each of the
//   greetings. If you need a refresher on how to get the current time, see Date Time
//   Formatting. When testing your program, you'll probably want to use a DateTime variable
//   you define, rather than the current time. Once you're confident the program works
//   correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
//   assign DateTime.Now as its value, which is often a better approach).

public class GreetMeNow
{
    public void GreetUser()
    {
        int nowTime = DateTime.Now.Hour;

        if (nowTime >= 0 && nowTime <= 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (nowTime > 12 && nowTime <= 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (nowTime > 18 && nowTime <= 20)
        {
            Console.WriteLine("Good Evening");
        }
        if (nowTime > 20)
        {
            Console.WriteLine("Good Night");
        }
    }
}