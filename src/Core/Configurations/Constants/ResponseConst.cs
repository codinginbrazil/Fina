namespace Core.Configurations.Constants;

public static class ResponseConst
{
    #region Success
    public const int SuccessCode = 200;
    public const string SuccessMessage = "success";
    public static readonly (int code, string message) Success = (SuccessCode, SuccessMessage);
    #endregion Success

    #region BadRequest
    public const int BadRequestCode = 502;
    public const string BadRequestMessage = "bad request";
    public static readonly (int code, string message) BadRequest = (BadRequestCode, BadRequestMessage);
    #endregion BadRequest

    #region NotFound
    public const int NotFoundCode = 404;
    public const string NotFoundMessage = "not found";
    public static readonly (int code, string message) NotFound = (NotFoundCode, NotFoundMessage);
    #endregion NotFound
}
