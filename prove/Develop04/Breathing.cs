public class Breathing : Activity
{
    private string startMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public void Breathe()
    {
        Console.Write("Breathe in...");

        AnimationCountdown(5);

        Console.WriteLine("");

        Console.Write("Breath out...");

        AnimationCountdown(5);

        Console.WriteLine("");
    }

    public void BreatheActivity()
    {
        DateTime endTime = StartDisplay(startMessage);

        Console.WriteLine("Empty your mind...");

        AnimationCountdown(3);

        while (startTime < endTime)
        {
            Breathe();
        }

        Display(_endMessage);
    }
}