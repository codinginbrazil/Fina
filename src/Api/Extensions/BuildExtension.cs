using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace Api.Extensions;

public static class BuildExtension
{
    //public static void AddConfiguraton(this WebApplicationBuilder)
    //{

    //}

    public static void AddDataContexts(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        builder.Services.AddScoped<IDbConnection>((sp) => new Npgsql.NpgsqlConnection(connectionString));
    }

    public static void AddDependencyInjection(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<Core.Interfaces.Repositories.Categories.IQueryRepository, Infrastructure.Repositories.Categories.QueryRepository>();

        builder.Services.AddTransient<Core.Interfaces.Repositories.Transactions.IQueryRepository, Infrastructure.Repositories.Transactions.QueryRepository>();
    }
}
