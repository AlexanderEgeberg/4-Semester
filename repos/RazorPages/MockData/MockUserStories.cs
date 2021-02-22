using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ...",1,3,"Medium"),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ...",1,3,"Medium"),
            new UserStory("Move Story", "As team member I want to move a Story So ...",1,3,"Medium"),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...",1,3,"Medium")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }
    }
}
