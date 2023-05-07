using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    public class Post
    {
        // Initialising some variables and some properties.
        private int _vote = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        
        // Method to display the post.
        public void DisplayPost()
        {
            Console.WriteLine("\nTitle: "+ Title);
            Console.WriteLine("Posted on: " + DateTime.Now);
            Console.WriteLine(Description);
        }

        // Method to upvote the post.
        public void Upvote()
        {
            _vote++;
        }

        // Method to downvote the post.
        public void Downvote()
        {
            _vote--;
        }

        // Method that returns the number of votes.
        public int ViewVotes()
        {
            return _vote;
        }
    }
}
