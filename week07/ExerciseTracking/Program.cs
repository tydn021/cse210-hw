using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        Swimming swimming = new Swimming(DateTime.Now, 22.5f, 5);

        Running running = new Running(DateTime.Now, 32, 4);

        Cycling cycling = new Cycling(DateTime.Now, 50, 24);

        List<Activity> activities = new List<Activity>();

        activities.Add(swimming);
        activities.Add(running);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}