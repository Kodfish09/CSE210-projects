using System; 

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new Reference();
        reff.SetReference("1 Nephi 3:7");
        List<Word> words = GetWords("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Scripture scrip = new Scripture();
        scrip.SetReference(reff);
        scrip.SetWords(words);

        bool yes = true;
        while (yes == true) 
        {
            Console.WriteLine(MakeMessage(scrip));
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string response = Console.ReadLine();
            if (response == "quit")
            {
                yes = false;
            } else {
                for (int i = 0; i < 10; i++) 
                {
                    if (scrip.CountWords() > 0) {
                        scrip.removeWord();
                    } else {
                        yes = false;
                        i = 10;
                    }
                }
            }
        }
        Console.WriteLine(MakeMessage(scrip));
    }

    static string MakeMessage (Scripture scrip)
    {
        string message = (scrip.GetReference().GetReference());
        foreach (Word w in scrip.GetWords())
        {
            message += $" {w.GetWord().ToString()}";
        }
        return message;
    }

    static List<Word> GetWords(string verses)
    {
        string[] vArray = verses.Split(" ");
        List<Word> final = new List<Word>();

        foreach (string w in vArray) 
        {
            Word word = new Word();
            word.SetWord(w);
            final.Add(word);
        }
        
        return final;
    }
}