using Api.Endpoints;
using Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfiguration();
builder.AddDataContexts();
builder.AddCrossOrigin();
builder.AddDocumentation();

builder.AddDependencyInjection();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
    app.ConfigureDevEnvironment();

app.UseCors(Api.Configurations.Constant.CorsPolicyName);
app.MapEndpoints();
app.Run();
