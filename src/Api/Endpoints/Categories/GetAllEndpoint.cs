using Core.Interfaces.Repositories.Categories;
using Core.Models;
using Core.Responses;

namespace Api.Endpoints.Categories;

public sealed class GetAllEndpoint : IEndpoint
{
    static void IEndpoint.Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/", Repository)
            .WithName("Categories: Get All")
            .WithSummary("Recupera todas as categorias")
            .WithDescription("Recupera todas as categorias")
            .WithOrder(5)
            .Produces<Response<IEnumerable<Category>?>>();
    }

    private static async Task<IResult> Repository(IQueryRepository queryRepository)
    {
        var result = await queryRepository.GetAll();
        return Results.Ok(result);
    }
}
