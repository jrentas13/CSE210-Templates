public class Listing: Activity
{
    List<string> listings = new List<string>();
    private int count;
    private string startMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private DateTime startTime;
    private DateTime currentTime;
    private DateTime endTime;


    public void UserList()
    {   
        Console.Write("> ");
        string userInput= Console.ReadLine();

        listings.Add(userInput);
    }

    public void ListingActivity()
    {
    
        _duration = StartDisplay(startMessage);

        Console.WriteLine("List as many responses that come to mind:");
        
        Prompt("ListingPrompts.txt");

        AnimationCountdown(3);

        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(_duration);
       
        int count = 0;
        for (int i = _duration; _duration > 0; _duration--)
        {
            UserList();

            currentTime = DateTime.Now;
            
            count++;

            if (currentTime == endTime)
            {
                break;
            }
        }

        Console.WriteLine($"You have listed {count} items!");

        Display(_endMessage);
    }
}