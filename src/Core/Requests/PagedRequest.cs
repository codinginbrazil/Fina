namespace Core.Requests;

public class PagedRequest : Request
{
    public uint PageSize { get; set; } = Configuration.DefaultPageSize;
    public uint PageNumber { get; set;} = Configuration.DefaultPageNumber;
}
