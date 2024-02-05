public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public BreathingActivity(int duration, string activityName) : base(duration, activityName)
    {
    }

    public void GetBreath()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(new string(' ', i) + i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

            Console.WriteLine("");
            Console.Write("Now breathe out...");

            for (int i = 5; i >= 1; i--)
            {
                Console.Write(new string(' ', i) + i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

            Console.WriteLine("");
        }
    }
}
