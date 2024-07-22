public class Activity
{
    protected string _endMessage = "Nice Job! You have finsihed the activity.";

    protected int _duration;

    public void AnimationCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(" +");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write(" x");

            Thread.Sleep(500);

            Console.Write("\b \b");
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

    public int StartDisplay(string message)
    {
        Console.WriteLine($"{message} \n");

        Console.WriteLine("Enter a time limit:");

        int duration = int.Parse(Console.ReadLine());

        return duration;
    }

    public void Display(string message)
    {
        Console.WriteLine(message);
    }
}