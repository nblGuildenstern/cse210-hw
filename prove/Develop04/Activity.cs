public class Activity {
    protected static string name;
    protected static string description;

    protected static Random random = new Random();

    public static void WaitAnimation(int seconds) {
        for(int i = seconds; i > 0; i-- ) {
            Console.Write("—");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write("\b \b");
    }

    public static void CountDown(int seconds) {
        for(int i = seconds; i > 0; i--) {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b \b\b");
        }
        Console.Write(" ");
    }

    protected static int Intro() {
        Console.WriteLine($"Welcome to the {name}\n");
        Console.WriteLine(description + "\n");

        int time = 0;
        while(time == 0) {
            Console.Write("How long, in seconds, would you like for your session? ");

            try {
                time = int.Parse(Console.ReadLine());
            } catch {
                Console.Clear();
                Console.WriteLine("Invalid input, please enter a valid time in seconds.\n");
            }
        }
        Console.Clear();
        Console.WriteLine("Get Ready...");
        WaitAnimation(4);
        Console.WriteLine();
        return time;
    }

    protected static void Outro(int time) {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        WaitAnimation(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {time} seconds of the {name}.");
        WaitAnimation(4);
    }
}