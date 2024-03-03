public class Breathing: Activity {
    public static void StartBreathing() {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int time = Intro();
        for(int i = time; i > 9; i-=10) {
            Console.Write("Breath in... ");
            CountDown(4);
            Console.WriteLine();
            Console.Write("Now breath out... ");
            CountDown(6);
            Console.WriteLine("\n");
        }
        Outro(time);
    }
}