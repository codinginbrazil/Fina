namespace Api.Endpoints;

public static class Endpoint
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("");

        endpoints.MapGroup("/")
            .WithTags("Health Check")
            .MapGet("/", () => new { message = "OK" });

        endpoints.MapGroup("v1/categories")
            .WithTags("Categories")
            //.MapEndpoint<Categories.CreateEndpoint>()
            //.MapEndpoint<Categories.UpdateEndpoint>()
            //.MapEndpoint<Categories.DeleteEndpoint>()
            //.MapEndpoint<Categories.GetByIdEndpoint>()
            .MapEndpoint<Categories.GetAllEndpoint>();

        endpoints.MapGroup("v1/transactions")
            .WithTags("Transactions")
            //.RequireAuthorization()
        //    .MapEndpoint<Transactions.CreateEndpoint>()
        //    .MapEndpoint<Transactions.UpdateEndpoint>()
        //    .MapEndpoint<Transactions.DeleteEndpoint>()
            .MapEndpoint<Transactions.GetAllEndpoint>();
        //    .MapEndpoint<Transactions.GetByIdEndpoint>()
        //    .MapEndpoint<Transactions.GetByPeriodEndpoint>();
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}