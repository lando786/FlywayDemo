public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IsComplete { get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt { get; set; }
}
