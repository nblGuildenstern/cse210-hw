using System;

class Program
{
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome() {
        System.Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUsername() {
        System.Console.Write("Enter your username. ");
        return Console.ReadLine();
    }
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber() {
        System.Console.Write("Enter your favorite number. ");
        try {
            return Int32.Parse(Console.ReadLine());
        } catch {
            System.Console.WriteLine("That is not a number");
            return PromptUserNumber();
        }
    }
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int num) {
        return num * num;
    }
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username, int num) {
        System.Console.WriteLine($"{username}, your favorite number squared is {num}. ");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUsername();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResult(username, numberSquared);
    }
}