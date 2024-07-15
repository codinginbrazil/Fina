using Core.Interfaces.Repositories.Transactions;
using Core.Models;
using Core.Responses;

namespace Api.Endpoints.Transactions;

public sealed class GetAllEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/", Repository)
            .WithName("Transactions: Get All")
            .WithSummary("Recupera todas as transações")
            .WithDescription("Recupera todas as transações")
            .WithOrder(5)
            .Produces<Response<IEnumerable<Transaction>?>>();
    }

    private static async Task<IResult> Repository(IQueryRepository queryRepository)
    {
        var result = await queryRepository.GetAll();
        return Results.Ok(result);
    }
}
