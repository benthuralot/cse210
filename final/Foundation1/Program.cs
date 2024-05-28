using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create 3-4 Videos
        Video vid1 = new Video("Exploring the Secrets of Ancient Civilizations", "History Buff", 1320);
        Video vid2 = new Video("Top 10 Easy Vegan Recipes for Beginners", "GreenEats", 900);
        Video vid3 = new Video("Mastering Python: From Basics to Advanced", "CodeAcademy", 2400);
        Video vid4 = new Video("The Ultimate Guide to Digital Photography", "Shutterbug Studio", 1800);

        // Add a list of 3-4 comments(with the commenter's name and text)
        Comment com1 = new Comment();
        Comment com2 = new Comment();
        Comment com3 = new Comment();
        Comment com4 = new Comment();
        
        vid1.AddComment(com1);
        vid1.AddComment(com2);
        vid1.AddComment(com3);
        vid1.AddComment(com4);

        Comment com5 = new Comment();
        Comment com6 = new Comment();
        Comment com7 = new Comment();

        vid2.AddComment(com5);
        vid2.AddComment(com6);
        vid2.AddComment(com7);

        Comment com8 = new Comment();
        Comment com9 = new Comment();
        Comment com10 = new Comment();
        
        vid3.AddComment(com8);
        vid3.AddComment(com9);
        vid3.AddComment(com10);

        Comment com11 = new Comment();
        Comment com12 = new Comment();
        Comment com13 = new Comment();
        Comment com14 = new Comment();

        vid4.AddComment(com11);
        vid4.AddComment(com12);
        vid4.AddComment(com13);
        vid4.AddComment(com14);


        // Put each of these videos in a list.

        List<Video> videos = new List<Video>();
        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);
        videos.Add(vid4);

        // Iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method)
        // List out all of the comments for that video. Repeat this display for each video in the list.
        foreach (Video v in videos)
        {
            v.DisplayAll(v);
        }

    }
}