using Core.Interfaces.Repositories.Categories;
using Core.Requests.Categories;

namespace Api.Endpoints.Categories;

public sealed class CreateEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }

    //private static async Task<IResult> Repository(ICommandRepository commandRepository, Create request)
    //{
    //    if (commandRepository is null)
    //    {
    //        var result = new ArgumentNullException(nameof(commandRepository)).Message;
    //        return null;
    //    }

    //    if (request is null)
    //    {
    //        var result = new ArgumentNullException(nameof(commandRepository)).Message;
    //        return null;
    //    }
    //}
}
