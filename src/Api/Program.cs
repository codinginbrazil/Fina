using System.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IDbConnection>((sp) => new Npgsql.NpgsqlConnection(connectionString));

builder.Services.AddTransient<Core.Repositories.Categories.IQueryRepository, Infrastructure.Repositories.Categories.QueryRepository>();

builder.Services.AddTransient<Core.Repositories.Transactions.IQueryRepository, Infrastructure.Repositories.Transactions.QueryRepository>();

var app = builder.Build();

app.MapGet("/", async (Core.Repositories.Categories.IQueryRepository queryRepository) =>
{
    var result = await queryRepository.GetAll();
    return Results.Ok(result);
});

app.Run();
