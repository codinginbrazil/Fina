using Core.Configurations.Constants;
using Core.Responses;

namespace Api.Configurations;

public static class CommonResult
{
    public static IResult Get<TModel>(Response<TModel> response)
    {
        return response.Code switch
        {
            ResponseConst.SuccessCode => Results.Ok(response),
            ResponseConst.NotFoundCode => Results.NotFound(response),
            ResponseConst.BadRequestCode => Results.BadRequest(response),
            _ => Results.NoContent()
        };
    }
}
