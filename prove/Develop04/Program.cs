using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while(choice != 4) {
            choice = DisplayMenu();
            Console.Clear();
            switch(choice) {
                case 1:
                    Breathing.StartBreathing();
                    break;
                case 2:
                    Reflecting.StartReflecting();
                    break;
                case 3:
                    Listing.StartListing();
                    break;
                default:
                    break;
            }
        }
    }

    private static int DisplayMenu() {
        Console.Clear();
        int choice = 0;
        while(choice == 0) {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            try {
                choice = int.Parse(Console.ReadLine());
            } catch {
                Console.Clear();
                Console.WriteLine("Invalid input, please enter a number correlating to a choice.\n");
            }
        }

        return choice;
    }
}