using Core.Interfaces.Repositories.Categories;
using Core.Models;
using Core.Requests.Categories;
using Core.Responses;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories.Categories;

public sealed class QueryRepository(IConfiguration configuration) : Repository(configuration), IQueryRepository
{
    public async Task<Response<IEnumerable<Category>>> GetAll()
    {
        using (var connection = CreateConnection())
        {
            try
            {
                connection.Open();
                string query = @"SELECT * FROM public.category LIMIT 100";
                var result = await connection.QueryAsync<Category>(query);

                return new Response<IEnumerable<Category>>(result);
            }
            catch (Exception)
            {
                return new Response<IEnumerable<Category>>([], 502, "Bad Request");
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public async Task<PagedResponse<IEnumerable<Category>?>> GetAll(GetAll request)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<Category?>> GetById(GetById request)
    {
        throw new NotImplementedException();
    }
}
