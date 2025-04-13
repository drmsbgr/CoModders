using System.Text.Json.Serialization;

namespace Entities.Dtos.Forum;

public record ForumDto
{
    public int Id { get; init; }
    public string? IconUrl { get; init; }
    public string? Header { get; init; }
    public int ForumGroupId { get; init; }
    [JsonIgnore]
    public Entities.ForumGroup? ForumGroup { get; init; }
}