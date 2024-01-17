using System;

class Program
{
    static void Main(string[] args)
    {
        var numList = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = 1;
        
        int sum = 0;
        int largest = 0;

        while(input != 0) {
            System.Console.Write("Enter a number: ");
            input = Int32.Parse(Console.ReadLine());
            if(input == 0) 
                break;
            numList.Add(input);

            sum += input;
            if(input > largest)
                largest = input;
        }

        float avg = sum / numList.Count;

        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}