using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("How To Draw Manga", "Mark Crilley", 1200);
        video1.AddComment(new Comment("Wow! Great video Mark!", "snoodle323"));
        video1.AddComment(new Comment("You are an amazing artist!!!!!", "Mardie4564"));
        video1.AddComment(new Comment("When are you rereleasing Akiko, Mark?", "TN1000th"));
        videos.Add(video1);

        Video video2 = new Video("Is Atlantis Real?", "Kosmographia", 7200);
        video2.AddComment(new Comment("Wow! I've never thought about it that way!", "snoodle323"));
        video2.AddComment(new Comment("Where did you get this information", "Mardie4564"));
        video2.AddComment(new Comment("I KNEW IT!!!!!!", "TN1000th"));
        videos.Add(video2);

        Video video3 = new Video("History of Narrow Gauge Railroading", "RailroadingHistoryChannel", 1200);
        video3.AddComment(new Comment("Trains are boring.", "snoodle323"));
        video3.AddComment(new Comment("Who cares?", "Mardie4564"));
        video3.AddComment(new Comment("I loved the little engines from Thomas and Friends and they were Narrow Gauge!", "TN1000th"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.GetVideoDisplay();
        }
    }

}