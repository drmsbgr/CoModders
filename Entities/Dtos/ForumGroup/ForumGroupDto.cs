namespace Entities.Dtos.ForumGroup;

public record ForumGroupDto
{
    public int Id { get; init; }
    public string? Header { get; init; }
    public ICollection<Entities.Forum>? Forums { get; }
}