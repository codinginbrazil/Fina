using Core.Configurations.Constants;
using System.Text.Json.Serialization;

namespace Core.Responses;

public class PagedResponse<TData> : Response<TData>
{
    public int CurrentPage { get; set; } = 1;

    public int PageSize{ get; set; } = 10;
    public int TotalCount { get; set; } = 0;

    public PagedResponse(TData data, int code = ResponseConst.SuccessCode, string message = ResponseConst.SuccessMessage) : base(data, code, message) { }

    public PagedResponse(TData data, (int code, string message) response) : base(data, response) { }

    [JsonConstructor]
    public PagedResponse(TData data, int totalCount, int currentPage, int pageSize = Constant.DefaultPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
}
