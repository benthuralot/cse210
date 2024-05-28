public class CommentGenertator
{
    List<string> _name;
    List<string> _commentText;

    public CommentGenertator()
    {
        _name = new List<string>();
        _commentText = new List<string>();

        // Add names
        // Male Names
        _name.Add("Enrique");
        _name.Add("Cullen");
        _name.Add("Troy");
        _name.Add("Lamar");
        _name.Add("Julian");
        _name.Add("Rory");
        // Female Names
        _name.Add("Sasha");
        _name.Add("Victoria");
        _name.Add("Kaliyah");
        _name.Add("Gabriela");
        _name.Add("Cass");
        _name.Add("Chloe");

        // Add comment text
        // Positive Comments
        _commentText.Add("This video is exactly what I needed today! Thank you for sharing such positive vibes and great content. Keep it up!");
        _commentText.Add("Wow, this was super informative and well-presented. Your energy is infectious! Can't wait to see more videos from you.");
        _commentText.Add("Amazing content as always! I love how you break down complex topics into easy-to-understand pieces. You're doing a fantastic job!");
        _commentText.Add("Your videos never fail to brighten my day. The quality and effort you put into your work are truly appreciated. Keep shining!");
        _commentText.Add("This was so inspiring! Your enthusiasm and passion are evident in every video. Thank you for being such a great source of motivation!");
        _commentText.Add("Another fantastic video! Your editing skills and storytelling are top-notch. Looking forward to your next upload!");
        // Negative Comments:
        _commentText.Add("I usually enjoy your content, but this video felt rushed and unorganized. I hope your next one is better.");
        _commentText.Add("This wasn't your best work. The information seemed outdated and not well-researched. Hoping for a return to your usual quality soon.");
        _commentText.Add("The audio and video quality in this one were really poor. It made it hard to focus on what you were saying.");
        _commentText.Add("I found this video quite boring and unengaging. It didn't hold my interest like your previous content.");
        _commentText.Add("You missed some key points on this topic, and it felt like you didn't fully understand the subject matter. Disappointed.");
        _commentText.Add("The editing was sloppy, and there were too many irrelevant tangents. This isn't up to your usual standard.");

    }

    public string GetRandomName()
    {
        Random random = new Random();
        int idx = random.Next(0, _name.Count);
        string randomName = _name[idx];

        return randomName;

    }
    public string GetRandomText()
    {
        Random random = new Random();
        int idx = random.Next(0, _commentText.Count);
        string randomText = _commentText[idx];

        return randomText;
    }

}