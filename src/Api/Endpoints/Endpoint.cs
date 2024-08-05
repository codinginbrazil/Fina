namespace Api.Endpoints;

public static class Endpoint
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("");

        endpoints.MapGroup("/")
            .WithTags("Health Check")
            .MapGet("/", () => new { message = "OK" });

        #region categories
        endpoints.MapGroup("v1/category")
            .WithTags("Categories")
            //.MapEndpoint<Categories.CreateEndpoint>()
            //.MapEndpoint<Categories.UpdateEndpoint>()
            //.MapEndpoint<Categories.DeleteEndpoint>()
            .MapEndpoint<Categories.GetByIdEndpoint>();

        endpoints.MapGroup("v1/categories")
            .WithTags("Categories")
            .MapEndpoint<Categories.GetAllEndpoint>();
        #endregion  categories

        #region transactions
        endpoints.MapGroup("v1/transaction")
            .WithTags("Transactions")
            //.RequireAuthorization()
            //.MapEndpoint<Transactions.CreateEndpoint>()
            //.MapEndpoint<Transactions.UpdateEndpoint>()
            //.MapEndpoint<Transactions.DeleteEndpoint>()
            .MapEndpoint<Transactions.GetByIdEndpoint>();
            //.MapEndpoint<Transactions.GetByPeriodEndpoint>();

        endpoints.MapGroup("v1/transactions")
            .WithTags("Transactions")
            .MapEndpoint<Transactions.GetAllEndpoint>();
        #endregion transactions
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}