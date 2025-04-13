namespace Entities;

public class Thread
{
    public Thread()
    {

    }

    public Thread(int id, string? header, string text, int forumId)
    {
        Id = id;
        Header = header;
        Text = text;
        ForumId = forumId;
    }

    public int Id { get; set; }
    public string? Header { get; set; }
    public string? Text { get; set; }
    public int ForumId { get; set; }
    public Forum? Forum { get; }
    public ICollection<Post>? Posts { get; }
}