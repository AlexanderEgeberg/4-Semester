using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPages.MockData;
using RazorPages.Models;

namespace RazorPages.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int id)
        {
            var userStory = userStories.Find(i => i.Id == id);
            return userStory;
        }

        public UserStory DeleteUserStory(int userstoryId)
        {
            var userStory = userStories.Find(i => i.Id == userstoryId);
            userStories.Remove(userStory);
            return userStory;
        }
    }
}