namespace Api.Endpoints.Categories;

public sealed class GetAllEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/", Repository)
            .WithName("Categories: Get All")
            .WithSummary("Recupera todas as categorias")
            .WithDescription("Recupera todas as categorias")
            .WithOrder(1)
            .Produces<Response<IEnumerable<Category>>>();
    }

    private static async Task<IResult> Repository(Core.Interfaces.Repositories.Categories.IQueryRepository queryRepository)
    {
        Response<IEnumerable<Category>> response = await queryRepository.GetAll();
        return CommonResult.Get(response);
    }
}
