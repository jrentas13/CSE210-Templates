public class Listing: Activity
{
    List<string> listings = new List<string>();
    private int count;
    private string startMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public void UserList()
    {   
        Console.Write("> ");
        string userInput= Console.ReadLine();

        listings.Add(userInput);
    }

    public void ListingActivity()
    {
        DateTime endTime =  StartDisplay(startMessage);

        Console.WriteLine("List as many responses that come to mind:");
        
        Prompt("ListingPrompts.txt");

        AnimationCountdown(3);

        int count = 0;
        while(startTime < endTime)
        {
            UserList();
            
            count++;
        }

        Console.WriteLine($"You have listed {count} items!");

        Display(_endMessage);
    }
}