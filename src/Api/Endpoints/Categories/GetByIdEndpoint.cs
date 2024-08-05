namespace Api.Endpoints.Categories;

public sealed class GetByIdEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/{Id:long}", Repository)
            .WithName("Categories: Get By Id")
            .WithSummary("Recupera categoria por id")
            .WithDescription("Recupera categoria por id")
            .WithOrder(1)
            .Produces<Response<Category>>();
    }

    private static async Task<IResult> Repository(long id, Core.Interfaces.Repositories.Categories.IQueryRepository queryRepository)
    {
        Core.Requests.Categories.GetById request = new()
        {
            Id = id,
            UserId = "development"
        };

        Response<Category> response = await queryRepository.GetById(request);
        return CommonResult.Get(response);
    }
}
