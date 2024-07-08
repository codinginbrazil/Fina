namespace Core.Requests;

public abstract class RequestWithId
{
    public string UserId { get; set; } = string.Empty;
    public long Id { get; set; }
}
