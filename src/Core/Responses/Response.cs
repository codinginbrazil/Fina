using Core.Configurations;
using System.Text.Json.Serialization;

namespace Core.Responses;

public abstract class Response<TData>
{
    private int _code = Constant.DefaultStatusCode;

    public string Message {get; set; } = "success";
    public TData? Data {get; set; }


    [JsonConstructor]
    protected Response() { }

    public Response(TData? data, int code = Constant.DefaultStatusCode, string message = "success")
    {
        _code = code;
        Data = data;
        Message = message;
    }


    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and < 300;
}
