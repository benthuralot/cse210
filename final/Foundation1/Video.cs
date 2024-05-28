public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayAll(Video v)
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length}secs | Comments: {v.GetComments()}");
        Console.WriteLine();

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
    
}