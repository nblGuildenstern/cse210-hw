public class Reflecting: Activity {
    private static string[] prompts = {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private static string[] questions = {
        "Why was this experience meaningful to you?", 
        "Had you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    public static void StartReflecting() {
        name = "Reflecting Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int time = Intro();
        System.Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        System.Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        System.Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        System.Console.WriteLine("You may begin in: ");
        CountDown(5);
        Console.Clear();
        int i = 0;
        for(i = time; i > 14; i-=15) {
            Console.WriteLine(questions[random.Next(questions.Length)]);
            WaitAnimation(15);
        }
        if(i >= 5) {
            Console.WriteLine(questions[random.Next(questions.Length)]);
            WaitAnimation(i);
        }
        Outro(time);
    }
}