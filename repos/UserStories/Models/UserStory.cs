using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStories.Models
{
    public class UserStory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public String StoryPoints { get; set; }
       
        private static int nextId = 1;

        public UserStory(string title, string description, int businessValue, int priority, string storyPoints)
        {
            Id = nextId++;
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            CreationDate = DateTime.Now;
            Priority = priority;
            StoryPoints = storyPoints;
        }

        public UserStory()
        {
            
        }
    }
}
