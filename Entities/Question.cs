namespace Entities;

public class Question
{
    public Question()
    {

    }


    public Question(int id, string? text, string? description)
    {
        Id = id;
        Text = text;
        Description = description;
    }

    public Question(string? text, string? description)
    {
        Text = text;
        Description = description;
    }
    public int Id { get; set; }
    public string? Text { get; set; }
    public string? Description { get; set; }
}
