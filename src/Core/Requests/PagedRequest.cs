using Core.Configurations;

namespace Core.Requests;

public class PagedRequest : Request
{
    public uint PageSize { get; set; } = Constant.DefaultPageSize;
    public uint PageNumber { get; set;} = Constant.DefaultPageNumber;
}
