namespace Core.Models;

public sealed class Category : Model
{
    public string? Description { get; set; } 
    public string Userld { get; set; } =  string.Empty;
}
