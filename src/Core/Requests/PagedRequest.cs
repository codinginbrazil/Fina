using Core.Configurations.Constants;

namespace Core.Requests;

public class PagedRequest : Request
{
    public int PageSize { get; set; } = Constant.DefaultPageSize;
    public int PageNumber { get; set;} = Constant.DefaultPageNumber;

    public int Offset => (PageNumber - 1) * PageSize;
}
