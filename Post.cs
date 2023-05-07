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
        public string Title { get; set; }
        public string Description { get; set; }
        private int _vote = 0;

        
        public void DisplayPost()
        {
            Console.WriteLine("\nTitle: "+ Title);
            Console.WriteLine("Posted on: " + DateTime.Now);
            Console.WriteLine(Description);
        }

        public void Upvote()
        {
            _vote++;
        }

        public void Downvote()
        {
            _vote--;
        }

        public int ViewVotes()
        {
            return _vote;
        }
    }
}
