namespace Entities;

public class ForumGroup
{
    public int Id { get; set; }
    public string? Header { get; set; }

    public ICollection<Forum>? Forums { get; set; }
}
