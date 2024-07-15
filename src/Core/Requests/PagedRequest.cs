using Core.Configurations.Constants;

namespace Core.Requests;

public class PagedRequest : Request
{
    public uint PageSize { get; set; } = Constant.DefaultPageSize;
    public uint PageNumber { get; set;} = Constant.DefaultPageNumber;
}
