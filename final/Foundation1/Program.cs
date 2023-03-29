using System;

class Program
{
    static void Main(string[] args)
    {

        List<Videos> videos = new List<Videos>();

        Videos video1 = new Videos();
        video1.SetAuthor("Grace");
        video1.SetTitle("John Doe");
        video1.SetTime(23);
        video1.SetComments("Max", "Great");
        video1.SetComments("Jerry", "Nice product");
        video1.SetComments("Drake", "Keep it up");
        

        Videos video2 = new Videos();
        video2.SetTitle("Ai");
        video2.SetAuthor("Popi");
        video2.SetTime (40);
        video2.SetComments("Paul", "Good Job");
        video2.SetComments("Migos", "We want more");
        video2.SetComments("Jason", "Perfect");

        Videos video3 = new Videos();
        video3.SetTitle("Power");
        video3.SetAuthor("John Doe");
        video3.SetTime(23);
        video3.SetComments("Andre", "This is so cool");
        video3.SetComments("Prince", "This is off the hook");
        video3.SetComments("Ken", "Really impressive");


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Videos video in videos)
        {
           video.DisplayMovie();
           Console.WriteLine("");

        }

    }
}