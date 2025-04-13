namespace Entities;

public class ForumGroup
{
    public ForumGroup()
    {

    }

    public ForumGroup(int id, string? header)
    {
        Id = id;
        Header = header;
    }

    public int Id { get; set; }
    public string? Header { get; set; }

    public ICollection<Forum>? Forums { get; }
}
