using System;
using System.Collections.Generic;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "Eshban Younis", 500);
        Video video2 = new Video("Advanced C# Programming", "Alex Christensen", 1500);
        Video video3 = new Video("C# Design Patterns", "Sarah Younis", 900);

        video1.AddComment(new Comment("User1", "Great introduction! Explained so well."));
        video1.AddComment(new Comment("User2", "Very helpful! Best!"));
        video1.AddComment(new Comment("User3", "Clear and concise."));

        video2.AddComment(new Comment("User4", "Loved the advanced topics. Best experience!"));
        video2.AddComment(new Comment("User5", "Awesome! Could you please share more content?"));
        video2.AddComment(new Comment("User6", "Excellent content! This is really worth it."));

        video3.AddComment(new Comment("User7", "Design patterns explained well."));
        video3.AddComment(new Comment("User8", "Very informative."));
        video3.AddComment(new Comment("User9", "Helped me a lot to learn new things."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Author}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
