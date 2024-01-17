using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool play = true;
        int game_count = 0;
        int low = 1;
        int high = 100;
        void EditDifficulty() {
            System.Console.WriteLine("What difficulty level? Between 1-5, or put 0 to see the difficulty levels");
            switch(Int32.Parse(Console.ReadLine())) {
                case 0: //print levels
                    Console.WriteLine("Number will be between 1 and...\n1. 10\n2. 100\n3. 500\n4. 1000\n5. 5000\n");
                    break;
                case 1:
                    high = 10;
                    break;
                case 2:
                    break;
                case 3:
                    high = 500;
                    break;
                case 4:
                    high = 1000;
                    break;
                case 5:
                    high = 5000;
                    break;
                case 123:
                    high = 10000000;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    EditDifficulty();
                    break;
            }
        }

        EditDifficulty();

        Console.WriteLine();

        while (play) {
            game_count++;
            System.Console.WriteLine($"This is game {game_count}.\n");
            int answer = random.Next(low, high);
            System.Console.Write($"Enter a number between {low} and {high}. ");
            int guess = Int32.Parse(Console.ReadLine());
            int guess_count = 1;
            while (guess != answer) {
                guess_count++;
                if (answer > guess) {
                    System.Console.Write("Enter a HIGHER number. ");
                    guess = Int32.Parse(Console.ReadLine());
                } else {
                    System.Console.Write("Enter a LOWER number. ");
                    guess = Int32.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine($"\nYou got it in {guess_count} tries! {guess} was the correct answer.\n");
            bool decided = false;
            while(!decided) {
                System.Console.WriteLine("Do you want to play again?\n1. Yes\n2. No\n3. Change difficulty and play again.\n");
                switch (Console.ReadLine()) {
                    case "1":
                        play = true;
                        decided = true;
                        break;
                    case "2":
                        System.Console.WriteLine("Thanks for playing! Goodbye.\n");
                        play = false;
                        decided = true;
                        break;
                    case "3":
                        EditDifficulty();
                        play = true;
                        decided = true;
                        break;
                    default:
                        System.Console.WriteLine("\nInvalid response, enter a 1 or a 2");
                        break;
                }
            }
            System.Console.WriteLine();
        }
    }
}