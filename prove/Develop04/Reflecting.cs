public class Reflecting: Activity
{
    List<string> reflection  = new List<string>();

    List<string> subReflections = new List<string>();

    private string startMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public void ReflectionActivity()
    {
        DateTime endTime = StartDisplay(startMessage);


        Console.WriteLine("Here we go...");
        Console.WriteLine("Here's something to reflect on:");

        Prompt("ReflectionPrompts.txt");

        Console.WriteLine("When you are ready, press enter.");
        string go = Console.ReadLine();

        while (startTime < endTime)
        {
            Prompt("ReflectionSubPrompts.txt");

            AnimationCountdown(5);

            Console.WriteLine("");
        }

        Display(_endMessage);
    }
}