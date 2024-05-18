public class Prompt
{
    public Random random;
    List<string> _questions = new List<string>();

    public Prompt()
    {
        random = new Random();

        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GeneratePrompt()
    {
        int index = random.Next(_questions.Count());
        return _questions[index];
    }
    
}
