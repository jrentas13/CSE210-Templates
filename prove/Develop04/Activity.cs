public class Activity
{
    protected string _endMessage = "Nice Job! You have finsihed the activity.";

    protected DateTime startTime = DateTime.Now;

    protected DateTime endTime;

    public void AnimationCountdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("x");

            Thread.Sleep(500);
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);
        }
    }

    public void Prompt(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        List<string> prompts = new List<string>(lines);

        Random random = new Random();
        int randomInt = random.Next(prompts.Count());

        Console.WriteLine(prompts[randomInt]);
    }

    public DateTime StartDisplay(string message)
    {
        Console.WriteLine($"{message} \n");

        Console.WriteLine("Enter a time limit:");

        int timeSec = int.Parse(Console.ReadLine());

        DateTime endTime = startTime.AddSeconds(timeSec);

        return endTime;
    }

    public void Display(string message)
    {
        Console.WriteLine(message);
    }
}