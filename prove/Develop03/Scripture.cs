using System.Runtime.CompilerServices;

public class Scripture
{
    private References _reference = new References("D&C","50","41");

    private List<Word> _words;

    private List<int> indices;

    private List<string> _newWords;

    string _wordsOfGod = "Fear not, little children, for you are mine, and I have overcome the world, and you are of them that my Father hath given me;";

    static List<Word> ParseSentenceToWordList(String sentence)
    {
        List<Word> words = new List<Word>();

        string[] locution = sentence.Split(' ');

        foreach (string word in locution)
        {
            words.Add(new Word(word));
        }
        return words;
    }

    public Scripture ()
    {
        _words = ParseSentenceToWordList(_wordsOfGod);
        indices = new List<int>();
        _newWords = new List<string>(_wordsOfGod.Split(' '));

        for (int j = 0; j < _words.Count(); j++)
        {
            indices.Add(j);
        }
    }

    public bool AllWordsHidden()
    {
        return indices.Count == 0;
    }
     
    public void HideWords()
    {
        Random random = new Random();
        int randomInt;

        for (int i = 0; i < 5; i++)
        {
            randomInt = random.Next(indices.Count());
            _newWords[indices[randomInt]] = _words[indices[randomInt]].BlankWord();
            indices.RemoveAt(randomInt);
        }
    }

    public void DisplayScripture()
    {
        string sentence = String.Join(" ", _newWords);
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(sentence);
    }
}

