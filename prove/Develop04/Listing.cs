public class Listing: Activity {
    private static string[] prompts = {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
    };
     
    public static void StartListing() {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int time = Intro();

        System.Console.WriteLine("List as many responses as you can for the following prompt:");
        System.Console.WriteLine($"---{prompts[random.Next(prompts.Length)]}---");
        System.Console.Write("You may begin in: ");
        CountDown(5);
        System.Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        var responses = new List<String>();

        while(currentTime < futureTime) {
            responses.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        Outro(time);
    }
}