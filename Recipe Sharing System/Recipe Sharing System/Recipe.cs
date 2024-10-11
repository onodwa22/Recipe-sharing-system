using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe_Sharing_System
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }

        public Recipe(string title, string description, string ingredients, string instructions, User user)
        {
            Title = title;
            Description = description;
            Ingredients = ingredients;
            Instructions = instructions;
            User = user;
            Rating = 0;
        }
    }
}
