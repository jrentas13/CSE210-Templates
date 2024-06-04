public class Word
{
    private string _word;

    private string blank = "";

    public Word(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        Console.Write($"{_word} ");
    }

    public string BlankWord()
    {
        for (int i = 0; i < _word.Length; i ++)
        {
            blank += "_";
        }
        return blank;
    }
}