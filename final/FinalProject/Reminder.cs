using System.Runtime.CompilerServices;

public class Reminder
{
    private string _time;
    private string _day;

    public Reminder()
    {

    }

    public Reminder(string day, string time)
    {
        _day = day;
        _time = time;
    }

    public void AddReminder()
    {
        Console.Write("Enter a day: ");
        _day = Console.ReadLine();
        Console.Write("Enter a time: ");
        _time = Console.ReadLine();
    }

    public void DisplayReminder()
    {
        Console.WriteLine($"Water plants on {_day} at {_time}.");
    }

    public string GetStringRepresentation()
    {
        return $"{_day}~{_time}";
    }
}