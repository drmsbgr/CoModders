namespace Entities;

public class Forum
{
    public Forum()
    {

    }

    public Forum(int id, string? header, int forumGroupId, string? iconUrl = "")
    {
        Id = id;
        IconUrl = iconUrl;
        Header = header;
        ForumGroupId = forumGroupId;
    }

    public int Id { get; set; }
    public string? IconUrl { get; set; }
    public string? Header { get; set; }
    public int ForumGroupId { get; set; }
    public ForumGroup? ForumGroup { get; set; }
    public ICollection<Thread>? Threads { get; }
}
