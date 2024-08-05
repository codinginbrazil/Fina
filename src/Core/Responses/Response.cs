using Core.Configurations.Constants;
using System.Text.Json.Serialization;

namespace Core.Responses;

public class Response<TData>
{
    public int Code { get; private set; } = ResponseConst.SuccessCode;
    public string Message {get; set; } = ResponseConst.SuccessMessage;
    public TData? Data {get; set; }

    [JsonConstructor]
    protected Response() { }

    public Response(TData data, (int code, string message) response)
    {
        Code = response.code;
        Message = response.message;
        Data = data;
    }

    public Response(TData? data, int code = ResponseConst.SuccessCode, string message = ResponseConst.SuccessMessage)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    [JsonIgnore]
    public bool IsSuccess => Code is >= 200 and < 300;
}
