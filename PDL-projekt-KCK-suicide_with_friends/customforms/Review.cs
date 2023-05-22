using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customforms
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public Review(int id, string title, string content, int rating)
        {
            Id = id;
            Title = title;
            Content = content;
            Rating = rating;
        }
        public void UpdateTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
        }

        public void UpdateRating(int newRating)
        {
            Rating = newRating;
        }

        public override string ToString()
        {
            return $"Review ID: {Id}\nTitle: {Title}\nContent: {Content}\nRating: {Rating}";
        }
    }
}

