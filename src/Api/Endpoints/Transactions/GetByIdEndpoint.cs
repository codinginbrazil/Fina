namespace Api.Endpoints.Transactions;

public sealed class GetByIdEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/{Id:long}", Repository)
        .WithName("Transactions: Get By Id")
        .WithSummary("Recupera transação por id")
        .WithDescription("Recupera transação por id")
        .WithOrder(1)
        .Produces<Response<Transaction>>();
    }

    private static async Task<IResult> Repository(long id, Core.Interfaces.Repositories.Transactions.IQueryRepository queryRepository)
    {
        Core.Requests.Transactions.GetById request = new()
        {
            Id = id,
            UserId = "development"
        };

        Response<Transaction> response = await queryRepository.GetById(request);
        return CommonResult.Get(response);
    }
}
