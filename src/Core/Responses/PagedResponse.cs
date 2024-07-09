using Core.Configurations;
using System.Text.Json.Serialization;

namespace Core.Responses;

public class PagedResponse<TData> : Response<TData>
{

    public int CurrentPage { get; set; }

    public int PageSize{ get; set; } = Constant.DefaultStatusCode;
    public int TotalCount { get; set; }


    public PagedResponse(TData? data, int code = Constant.DefaultStatusCode, string message = "success") : base(data, code, message) { }

    [JsonConstructor]
    public PagedResponse(TData? data, int totalCount, int currentPage, int pageSize = Constant.DefaultPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }


    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
}
