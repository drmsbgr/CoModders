namespace Entities;

public class Post
{
    public Post()
    {

    }

    public Post(int id, string? header, int threadId)
    {
        Id = id;
        Header = header;
        ThreadId = threadId;
    }

    public int Id { get; set; }
    public string? Header { get; set; }
    public int ThreadId { get; set; }
    public Thread? Thread { get; }
}