using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


class Comment
{
    public string Name {get; set;}
    public string Text {get; set;}

    public Comment(string name, string text){
        Name = name;
        Text = text;
    }
}

class Video {
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    public List<Comment> Comments{get; set;}

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments(){
        return Comments.Count;
    }
    public void AddComment(Comment comment){
        Comments.Add(comment);
    }

    public void DisplayVideoInfo(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in Comments){
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }

}

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Class! This is the YOUTUBE VIDEO project.\n");

        Video video1 = new Video("Learn C# in 30 minutes", "Eshban Younis", 2000);
        Video video2 = new Video("C# Advance Features", "Mathew Kearl", 2300);
        Video video3 = new Video("C# for beginners", "Alex Christensen", 1500 );


        video1.AddComment(new Comment("Sarah", "Great tutorial!"));
        video1.AddComment(new Comment("Asad", "Very clear explanation, thanks!"));
        video1.AddComment(new Comment("Ezekiel", "I learned a lot!"));

        video2.AddComment(new Comment("David", "Amazing content, very helpful!"));
        video2.AddComment(new Comment("Rahila", "Best video Can't wait for the next video."));
        video2.AddComment(new Comment("Frank", "Really worth it."));

        video3.AddComment(new Comment("Grace", "This is perfect for beginners."));
        video3.AddComment(new Comment("Jane", "Thank You, I'm finally understanding C#!"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos){
            video.DisplayVideoInfo();
        }

    }
}