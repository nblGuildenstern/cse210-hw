using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static Journal journal = new Journal(null);


    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        while (choice != 6) {
            try {
                choice = DisplayOptions();
            } catch {
                Console.Clear();
                choice = 0;
            } finally {
                EnactChoice(choice);
            }
        }
    }


    public static int DisplayOptions() {
        System.Console.WriteLine("Please select one of the following choices:");
        int choice;

        if(journal.filename == null) {
            System.Console.WriteLine("1. Load");
            System.Console.WriteLine("2. Create new jounal");
            System.Console.WriteLine("3. Quit");
            choice = int.Parse(Console.ReadLine()) + 3;
        } else {
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Save");
            System.Console.WriteLine("4. Load");
            System.Console.WriteLine("5. Create new jounal");
            System.Console.WriteLine("6. Quit");
            System.Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
        }

        Console.Clear();
        return choice;
    }

    public static void EnactChoice(int choice) {
        switch(choice) {
            case 1: // Write
                PromptUser();
                break;
            case 2: // Display
                journal.DisplayEntries();
                break;
            case 3: // Save
                journal.Save();
                break;
            case 4: // Load
                System.Console.Write("Enter the name of the file to load. ");
                string fileToLoad = Console.ReadLine(); 
                journal.Load(fileToLoad);
                Console.Clear();
                break;
            case 5: // Create Journal
                System.Console.Write("Enter the name of the file to create. ");
                string fileToCreate = Console.ReadLine();
                journal.NewJournal(fileToCreate);
                break;
            case 6: // Quit
                Console.Clear();
                System.Console.WriteLine("Thank you for using this Journal software!");
                break;
            default:
                System.Console.WriteLine("Invalid response, please choose a valid option.");
                System.Console.WriteLine();
                break;
        }
    }

    public static void PromptUser() {
        // System.Console.WriteLine(journal.prompts);
        string prompt = journal.GetRandomPrompt();
        System.Console.WriteLine(prompt);
        string response = System.Console.ReadLine();

        journal.CreateEntry(prompt, response);

        Console.Clear();
    }

}