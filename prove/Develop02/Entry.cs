public class Entry
{
    public string _entry;

    public string _date;

    public string _reflection;

    public Entry (string _date, string _reflection, string _entry) 
    {
            this._date = _date;
            this._reflection = _reflection;
            this._entry = _entry;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}\n{_reflection}\n{_entry}");

    }
}