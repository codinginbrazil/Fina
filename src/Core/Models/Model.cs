namespace Core.Models;

public abstract class Model
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
}
