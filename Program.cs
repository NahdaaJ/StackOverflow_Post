using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();
            Console.WriteLine("Please enter the title of your post: ");
            newPost.Title = Console.ReadLine();
            Console.WriteLine("\nPlease enter the content of your post: ");
            newPost.Description = Console.ReadLine();

            newPost.DisplayPost();

            while(true)
            {
                Console.Write("Upvote (u), Downvote (d) or View Votes (v): ");
                var userInput = Console.ReadLine().ToLower();

                if(userInput == "u")
                {
                    newPost.Upvote();
                    Console.WriteLine("Upvoted.");
                }
                else if(userInput == "d")
                {
                    newPost.Downvote();
                    Console.WriteLine("Downvoted.");
                }
                else if (userInput == "v")
                {
                    newPost.DisplayPost();
                    Console.WriteLine("Votes: "+ newPost.ViewVotes());
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }
    }
}