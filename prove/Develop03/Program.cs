using System;

class Program
{
    public static Scripture scripture = new Scripture("Proverbs", "3", "5-6", "Trust in the Lord with all your heart, and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy path");

    static void Main(string[] args)
    {
        bool userQuit = false;
        bool programCompleted = false;
        while(!userQuit && !programCompleted) {
            if(DisplayMenu().ToLower() == "quit") {
                userQuit = true;
            }
        }
    }

    public static string DisplayMenu() {
        scripture.Display();
        System.Console.WriteLine();
        System.Console.WriteLine("Press enter to continue or type quit to exit the program.");
        return Console.ReadLine();
    }
}