using Core.Interfaces.Repositories.Transactions;
using Core.Models;
using Core.Requests.Transactions;
using Core.Responses;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories.Transactions;

public sealed class QueryRepository(IConfiguration configuration) : Repository(configuration), IQueryRepository
{
    public async Task<Response<IEnumerable<Transaction>>> GetAll()
    {
        using (var connection = CreateConnection())
        {
            try
            {
                connection.Open();
                string query = @"SELECT * FROM public.transaction LIMIT 100";
                var result = await connection.QueryAsync<Transaction>(query);

                return new Response<IEnumerable<Transaction>>(result);
            }
            catch (Exception)
            {
                return new Response<IEnumerable<Transaction>>([], 502, "Bad Request");
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public Task<Response<Transaction?>> GetById(GetById request)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResponse<IEnumerable<Transaction>?>> GetByPeriod(GetByPeriod request)
    {
        throw new NotImplementedException();
    }
}
