using AssignmentForVote;
using System;
using System.Security.Cryptography;

namespace AssignmentForVote
{
    class Post
    {
        public String title { get; set; }
        public String Description { get; set; }

        public DateTime creationdate = DateTime.Now;

        private int votes;

       /*   public String GetTitle()
          {
              return title;
          }
          public String SetTitle(String titl)
          {
              title = titl;
          }
          public String GetDesc()
           {
               return Description;
            }
          public String SetDesc(String Desc)
            {
                 Description=Desc;
            }*/
        public int DisplayVotes()
        {
            return votes;
        }
        public void UpVote()
        {
            votes++;
            //votes + 1;
        }
        public void DownVote()
        {
            votes--;
            //votes - 1;
        }   
    }

    }

    class Program
    {
        static void Main(string[] args)
        {

        /* for (int i = 0;i< 10; i++)
         {
           var newpost = new Post
            {
                title = "Hello This is first Post",
                Description = "This is post Related To .Net Begginers"

            };
            Console.WriteLine(newpost.title);
            Console.WriteLine(newpost.Description);
            Console.WriteLine(newpost.creationdate);
            newpost.UpVote();
            newpost.UpVote();
            newpost.UpVote();
            newpost.UpVote();
            newpost.DownVote();
            newpost.DownVote();
            Console.WriteLine("Number of votes: " + newpost.DisplayVotes());
        } */
        //First Post
        var newpost = new Post
        {
            title = "Hello This is first Post",
            Description="This is post Related To .Net Begginers"

        };
         Console.WriteLine(newpost.title);
         Console.WriteLine(newpost.Description);
         Console.WriteLine(newpost.creationdate);
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.UpVote();
         newpost.DownVote();
         newpost.DownVote();
         newpost.DownVote();
         newpost.DownVote();
        Console.WriteLine("Number of votes: " + newpost.DisplayVotes());
        //Second Post
        var npost = new Post
        {
            title = "post for fullstack developer ",
            Description="All The Technologies are here for implementation"
        };
        Console.WriteLine(npost.title);
        Console.WriteLine(npost.Description);
        Console.WriteLine(npost.creationdate);
        npost.UpVote();
        npost.UpVote();
        npost.UpVote();
        npost.UpVote();
        npost.UpVote();
        npost.UpVote();
        npost.DownVote();
        npost.DownVote();
        npost.DownVote();
        npost.DownVote();
        Console.WriteLine("number of posts:" + npost.DisplayVotes());
        //Console.WriteLine("no of upvotes:", newpost.UpVote());
    }
}

