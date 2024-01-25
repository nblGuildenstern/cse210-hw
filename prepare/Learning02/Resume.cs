public class Resume {
    public string name;
    public List<Job> jobList = new List<Job>();

    public void DisplayResume() {
        System.Console.WriteLine("Name: " + name);
        System.Console.WriteLine("Jobs: ");
        foreach (Job job in jobList)
        {
            job.DisplayJob();
        }
    }
}