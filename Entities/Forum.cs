namespace Entities;

public class Forum
{
    public int Id { get; set; }
    public string? Header { get; set; }
    public int ForumGroupId { get; set; }
    public ForumGroup? Group { get; set; }
}
