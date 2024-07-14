using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddDataContexts();
builder.AddDependencyInjection();

var app = builder.Build();

app.MapGet("/", async (Core.Interfaces.Repositories.Categories.IQueryRepository queryRepository) =>
{
    var result = await queryRepository.GetAll();
    return Results.Ok(result);
});

app.Run();
