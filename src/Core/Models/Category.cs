namespace Core.Models;

public sealed class Category : Model
{
    public string? Description { get; set; } 
    public string UserId { get; set; } =  string.Empty;
}
