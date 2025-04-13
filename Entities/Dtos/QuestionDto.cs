namespace Entities.Dtos;

public record QuestionDto
{
    public int Id { get; init; }
    public string? Text { get; init; }
    public string? Description { get; init; }
}