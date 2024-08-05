using Core.Requests.Categories;

namespace Core.Interfaces.Repositories.Categories;

public interface IQueryRepository
{
    Task<Response<IEnumerable<Models.Category>>> GetAll();
    Task<PagedResponse<IEnumerable<Models.Category>>> GetAll(GetAll request);
    Task<Response<Models.Category>> GetById(GetById request);
}
