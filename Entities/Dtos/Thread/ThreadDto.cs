namespace Entities.Dtos.Thread;

public record ThreadDto
{
    public int Id { get; init; }
    public string? Header { get; init; }
    public string? Text { get; set; }
    public int ForumId { get; init; }
    public Entities.Forum? Forum { get; }
    public ICollection<Post>? Posts { get; }
}