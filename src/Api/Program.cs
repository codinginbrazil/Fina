using System.Data;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IDbConnection>((sp) => new Npgsql.NpgsqlConnection(connectionString));

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
