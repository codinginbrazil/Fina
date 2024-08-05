using Core.Configurations.Constants;
using Core.Configurations.Exceptions;
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
                string sql = @"SELECT * FROM public.category LIMIT 100";
                IEnumerable<Category> result = await connection.QueryAsync<Category>(sql);
                return new Response<IEnumerable<Category>>(result);
            }
            catch (CommonException)
            {
                return new Response<IEnumerable<Category>>([], ResponseConst.BadRequest);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public async Task<PagedResponse<IEnumerable<Category>>> GetAll(GetAll request)
    {
        using (var connection = CreateConnection())
        {
            try
            {
                connection.Open();
                

                string sql = @"SELECT * FROM public.category ORDER BY id LIMIT @PageSize OFFSET @Offset";
                var parameters = new { request.PageSize, request.Offset };

                IEnumerable<Category> result = await connection.QueryAsync<Category>(sql, parameters);

                sql = @"SELECT COUNT(*) FROM public.category";
                int totalRecords = await connection.ExecuteScalarAsync<int>(sql);

                return new PagedResponse<IEnumerable<Category>>(result, request.PageNumber, request.PageSize, totalRecords);
            }
            catch (CommonException)
            {
                return new PagedResponse<IEnumerable<Category>>([], ResponseConst.BadRequest);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public async Task<Response<Category>> GetById(GetById request)
    {
        using (var connection = CreateConnection())
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM public.category WHERE id = @Id";
                Category? result = await connection.QuerySingleOrDefaultAsync<Category>(sql, new { request.Id });

                if (result is null)
                    return new Response<Category>(new Category(), ResponseConst.NotFound);

                return new Response<Category>(result);
            }
            catch (CommonException)
            {
                return new Response<Category>(new Category(), ResponseConst.BadRequest);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
