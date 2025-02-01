using System;
using System.Net;
using System.IO;
using System.IO.Enumeration;
using System.Reflection;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool on = true;
        while (on == true) {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Delete\n6. Quit\nWhat would you like to do?");
            string response = Console.ReadLine();

            if (response == "1") {
                journal.entries.Add(newEntry());
            }
            if (response == "2") {
                Display(journal);
            }
            if (response == "3") {
                journal = loadJournal();
            }
            if (response == "4") {
                saveJournal(journal);
            }
            if (response == "5") {
                deleteJournal();
            }
            if (response == "6") {
                on = false;
            }
        }
    }

    static Entry newEntry() {
        List<string> prompts = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the most colorful thing I saw today?",
            "What crazy idea did I have today?",
            "Who do I need to reach out to tomorrow? Why?"
        };

        string currPrompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(currPrompt);
        string entryText = Console.ReadLine();

        Entry currEntry = new Entry();
        currEntry.date = DateTime.Now.ToShortDateString();
        currEntry.prompt = currPrompt;
        currEntry.text = entryText;

        return currEntry;
    }

    static void Display(Journal j) {
        foreach (Entry entry in j.entries) {
            Console.WriteLine($"\nDate: {entry.date} - Prompt: {entry.prompt}\n{entry.text}");
        }
        Console.WriteLine("\nHit Enter when finished. ");
        Console.ReadLine();
    }

    static Journal loadJournal() {
        //Gets all the files in the current directory
        string[] files = Directory.GetFiles(@"C:\Users\kadem\Documents\CSE210\CSE210-projects\prove\Develop02");
        List<string> journals = new List<string>();
        //Finds all the journal files in the directory
        foreach (string f in files) {
            string file = Path.GetFileName(f);
            if (file.Substring(0,5) == "-339-") {
                journals.Add(file);
            }
        }
        
        //Runs this code if there are journals already saved. 
        if (journals.Count != 0) {

            //Prints each journal on its own line and numbers it sequentially
            foreach (string j in journals) {
                Console.WriteLine($"{journals.FindIndex(a => a.Contains(j)) + 1}. {j.Remove(j.Length-4).Remove(0,5)}");
            }

            //Gets the user's selection and passes it into the variable "filename"
            Console.WriteLine("Please pick the journal you would like to load. ");
            int jSelec = int.Parse(Console.ReadLine())-1;
            string filename = journals[jSelec];

            //Reads all the selected files llines into an array of strings. This puts each entry in its own element of the array. 
            string[] lines = System.IO.File.ReadAllLines(filename);
            Journal journal = new Journal();

            //Splits each entry into date, prompt, and text
            foreach (string line in lines) {
                Entry entry = new Entry();
                string[] parts = line.Split("~|~");

                entry.date = parts[0];
                entry.prompt = parts[1];
                entry.text = parts[2];

                //Adds the entry into the journal
                journal.entries.Add(entry);
            }

            Console.WriteLine("Your journal has been loaded. Press Enter to achknowledge. ");
            Console.ReadLine();

            return journal;
        } else {
            Console.WriteLine("There are no journals available to load. Press Enter to achknowledge. ");
            Console.ReadLine();
            return null;
        }
    }

    static void saveJournal(Journal j) {
        Console.WriteLine("What is the file name? No file extensions please. ");
        string filename = "-339-"+Console.ReadLine()+".txt";

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Entry entry in j.entries) {
                outputFile.WriteLine($"{entry.date}~|~{entry.prompt}~|~{entry.text}");
            }
        }

        Console.WriteLine("Your journal has been saved. Press Enter to achknowledge. ");
        Console.ReadLine();
    }
    static void deleteJournal() {
        //Gets all the files in the current directory
        string[] files = Directory.GetFiles(@"C:\Users\kadem\Documents\CSE210\CSE210-projects\prove\Develop02");
        List<string> journals = new List<string>();
        //Finds all the journal files in the directory
        foreach (string f in files) {
            string file = Path.GetFileName(f);
            if (file.Substring(0,5) == "-339-") {
                journals.Add(file);
            }
        }

        if (journals.Count != 0) {

            //Prints each journal on its own line and numbers it sequentially
            foreach (string j in journals) {
                Console.WriteLine($"{journals.FindIndex(a => a.Contains(j)) + 1}. {j.Remove(j.Length-4).Remove(0,5)}");
            }

            //Gets the user's selection and passes it into the variable "filename"
            Console.WriteLine("Please pick the journal you would like to delete. ");
            int jSelec = int.Parse(Console.ReadLine())-1;
            string filename = journals[jSelec];

            File.Delete(filename);
            Console.WriteLine("Your journal has been deleted. Press Enter to achknowledge. ");
            Console.ReadLine();
        } else {
            Console.WriteLine("There are no journal to delete. Press Enter to achknowledge. ");
            Console.ReadLine();
        }
    }
}

public class Entry
{
    public string date;
    public string prompt;
    public string text;
}

public class Journal
{
    public List<Entry> entries = new List<Entry>();
}