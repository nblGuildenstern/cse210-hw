using System.Security.Cryptography;
using System.IO;

public class Journal {
    private List<Entry> entries = new List<Entry>();
    public string filename = default;
    public List<string> prompts = new List<string>();
    
    public static Random random = new Random();
    
    public Journal(string filename) {
        prompts.Add("What was your favorite thing you did today? ");
        prompts.Add("If you had one thing you could do over today, what would it be? ");
        prompts.Add("What was the best part of your day? ");
        prompts.Add("Who was the most interacting person you interacted with today? ");
        prompts.Add("What was the best part of my day? ");
        prompts.Add("How did I see the hand of the Lord in my life today? ");
        prompts.Add("What was the strongest emotion I felt today? ");
        prompts.Add("What was your favorite food you ate today? ");
        this.filename = filename;
    }

    public void CreateEntry(string prompt, string response) {
        DateTime dateTime = DateTime.Now;
        string dateText = dateTime.ToShortDateString();
        Entry entry = new Entry(response, prompt, dateText);
        entries.Add(entry);
    }

    public string GetRandomPrompt() {
        int index = random.Next(0, prompts.Count);
        return prompts[index];
    }

    public void DisplayEntries() {
        Console.Clear();
        if(entries.Count == 0) {
            System.Console.WriteLine($"There are no entries in this journal. ({filename})");
        }

        foreach(Entry entry in entries) {
            System.Console.WriteLine(entry.date);
            System.Console.WriteLine(entry.prompt);
            System.Console.WriteLine(entry.response);
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    public void Save() {
        System.Console.WriteLine(filename);
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (Entry entry in entries) {
                outputFile.WriteLine(entry.date);
                outputFile.WriteLine(entry.prompt);
                outputFile.WriteLine(entry.response);
                outputFile.WriteLine();
            }
        }
    }

    public void Load(string loadFile) {
        if(!loadFile.Contains(".txt"))
            loadFile += ".txt";
        string[] lines = new string[0];
        try {
            lines = System.IO.File.ReadAllLines(loadFile);
        } catch {
            System.Console.WriteLine(loadFile + " does not exist. Would you like to create it? (1. yes; 2. no)");
            int input = int.Parse(Console.ReadLine());
            if(input == 1) {
                NewJournal(loadFile);
            }
            return;
        }
        string date = "";
        string prompt = "";
        string response = "";
        entries.Clear();
        for(int i = 0; i < lines.Length; i++) {
            switch(i%4) {
                case 0:
                    date = lines[i];
                    break;
                case 1:
                    prompt = lines[i];
                    break;
                case 2:
                    response = lines[i];
                    break;
                case 3:
                    entries.Add(new Entry(response, prompt, date));
                    break;
            }
        }

        filename = loadFile;
    }

    public void NewJournal(string fileToCreate) {
        if(!fileToCreate.Contains(".txt"))
            fileToCreate += ".txt";
        try {
            File.Create(fileToCreate);
        } catch {
            System.Console.WriteLine(fileToCreate + " already exists, file is now open. \n");
        }
        
        filename = fileToCreate;
    }
}