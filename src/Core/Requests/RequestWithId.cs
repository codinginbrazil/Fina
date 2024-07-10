namespace Core.Requests;

public abstract class RequestWithId : Request
{
    public long Id { get; set; }
}
