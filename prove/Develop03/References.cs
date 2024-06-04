public class References
{
    private string _book;

    private string _chapter;

    private string _verse1;

    private string _verse2;

    public References(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse;
    }

    public References(string book, string chapter, string verse1, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    public string GetReference()
    {
        string single = $"{_book} {_chapter}:{_verse1}";
        return single;
    }

    public string GetReferenceMulti()
    {
        string multi = $"{_book} {_chapter}:{_verse1}-{_verse2}";
        return multi;
    }
}