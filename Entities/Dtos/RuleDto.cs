namespace Entities.Dtos;

public record RuleDto
{
    public int Id { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
}