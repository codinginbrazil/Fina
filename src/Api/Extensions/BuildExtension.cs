using Core.Configurations.Constants;
using System.Data;

namespace Api.Extensions;

public static class BuildExtension
{
    public static void AddConfiguration(this WebApplicationBuilder builder)
    {
       BackendConst.Url = builder.Configuration.GetValue<string>("BackendUrl") ?? string.Empty;
       FrontendConst.Url = builder.Configuration.GetValue<string>("FrontendUrl") ?? string.Empty;
    }

    public static void AddCrossOrigin(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(
            options => options.AddPolicy(
                Configurations.Constant.CorsPolicyName, policy => policy
                    .WithOrigins([BackendConst.Url, FrontendConst.Url])
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
            )
        );
    }

    public static void AddDataContexts(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        builder.Services.AddScoped<IDbConnection>((sp) => new Npgsql.NpgsqlConnection(connectionString));
    }

    public static void AddDependencyInjection(this WebApplicationBuilder builder)
    {
        #region Categories
        builder.Services.AddTransient<Core.Interfaces.Repositories.Categories.IQueryRepository, Infrastructure.Repositories.Categories.QueryRepository>();
        #endregion Categories

        #region Transactions
        builder.Services.AddTransient<Core.Interfaces.Repositories.Transactions.IQueryRepository, Infrastructure.Repositories.Transactions.QueryRepository>();
        #endregion Transactions
    }

    public static void AddDocumentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(x =>
        {
            x.CustomSchemaIds(n => n.FullName);
        });
    }
}
