using Api.Endpoints;
using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddDataContexts();
builder.AddDependencyInjection();

var app = builder.Build();

app.MapEndpoints();

app.Run();
