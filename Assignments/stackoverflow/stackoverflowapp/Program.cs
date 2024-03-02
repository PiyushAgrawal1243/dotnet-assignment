
using System;


namespace StackOverFlow {

class Program
{
    static void Main(string[] args)
    {
        StackOverFlow post = new StackOverFlow("Stackoverflow Post", "This is a post about stackoverflow.");

        post.UpVote();
        post.UpVote();
        post.DownVote();

        Console.WriteLine($"Title: {post.Title}");
        Console.WriteLine($"Description: {post.Description}");
        Console.WriteLine($"Creation Time: {post.CreationTime}");
        Console.WriteLine($"Vote Count: {post.VoteCount}");
    }
}



}