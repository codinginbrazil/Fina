namespace Api.Endpoints.Transactions;

public sealed class GetAllEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/", Repository)
            .WithName("Transactions: Get All")
            .WithSummary("Recupera todas as transações")
            .WithDescription("Recupera todas as transações")
            .WithOrder(1)
            .Produces<Response<IEnumerable<Transaction>>>();
    }

    private static async Task<IResult> Repository(Core.Interfaces.Repositories.Transactions.IQueryRepository queryRepository)
    {
        Response<IEnumerable<Transaction>> response = await queryRepository.GetAll();
        return CommonResult.Get(response);
    }
}
