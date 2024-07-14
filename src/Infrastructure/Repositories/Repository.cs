using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure.Repositories;

public abstract class Repository
{
    private readonly IConfiguration _configuration;

    protected Repository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected IDbConnection CreateConnection()
    {
        var connectionString = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        return new Npgsql.NpgsqlConnection(connectionString);
    }
}
