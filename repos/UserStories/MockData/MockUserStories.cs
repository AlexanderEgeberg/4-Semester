using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;

namespace UserStories.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ...",9,5, "Medium"),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ...", 5, 2, "Small"),
            new UserStory("Move Story", "As team member I want to move a Story So ...", 8, 4, "Large"),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...", 2, 2, "Medium")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }
    }
}
