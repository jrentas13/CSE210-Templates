using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public string _date;

    public string _page;

    public Prompt _reflection = new Prompt();

    public List<Entry> _entries = new List<Entry>();

    public void WriteEntry()
    {
        Console.Write("Enter the date of entry: ");
        _date = Console.ReadLine();

        string _prompt = _reflection.GeneratePrompt();

        Console.WriteLine(_prompt);


        _page = Console.ReadLine();


        Entry _entry = new Entry(_date, _prompt, _page);

        _entries.Add(_entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry a in _entries)
        {
            a.DisplayEntry();
        }
    }
}