using Core.Configurations.Constants;
using Core.Configurations.Exceptions;
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
                string sql = @"SELECT * FROM public.transaction LIMIT 100";
                IEnumerable<Transaction>? result = await connection.QueryAsync<Transaction>(sql);
                return new Response<IEnumerable<Transaction>>(result);
            }
            catch (CommonException)
            {
                return new Response<IEnumerable<Transaction>>([], ResponseConst.BadRequest);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public async Task<Response<Transaction>> GetById(GetById request)
    {
        using (var connection = CreateConnection())
        {
            try
            {
                connection.Open();
                long id = request.Id;
                string sql = "SELECT * FROM public.transaction WHERE id = @Id";
                Transaction? result = await connection.QuerySingleOrDefaultAsync<Transaction>(sql, new { Id = id });

                if (result is null)
                    return new Response<Transaction>(new Transaction(), ResponseConst.NotFound);

                return new Response<Transaction>(result);
            }
            catch (CommonException)
            {
                return new Response<Transaction>(new Transaction(), ResponseConst.BadRequest);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public Task<PagedResponse<IEnumerable<Transaction>>> GetByPeriod(GetByPeriod request)
    {
        throw new NotImplementedException();
    }
}
