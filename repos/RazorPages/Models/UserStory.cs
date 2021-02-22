using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class UserStory
    {
        private static int nextId = 0;

        public  int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BusinessValue { get; set; }
        public DateTime CreationDate { get { return DateTime.Now; } }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }

        public UserStory(string title, string description, int businessValue, int priority, string storyPoints)
        {
            Id = nextId;
            nextId++;
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            Priority = priority;
            StoryPoints = storyPoints;
        }

        public UserStory()
        {
            
        }

    }
}
