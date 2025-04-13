namespace Entities;

public class Rule
{
    public Rule()
    {

    }


    public Rule(int id, string? title, string? description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public Rule(string? title, string? description)
    {
        Title = title;
        Description = description;
    }

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
