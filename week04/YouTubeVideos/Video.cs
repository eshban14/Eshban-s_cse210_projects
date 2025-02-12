using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }

        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }

    public class Video
    {
        private string title;
        private string author;
        private int lengthInSeconds;
        private List<Comment> comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthInSeconds = lengthInSeconds;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetLengthInSeconds()
        {
            return lengthInSeconds;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}
