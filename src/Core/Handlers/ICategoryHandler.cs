using Core.Requests.Categories;

namespace Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> Create(Create request);
    Task<Response<Category?>> Update(Update request);
    Task<Response<Category?>> Delete(Delete request);
    Task<Response<Category?>> GetById(GetById request);
    Task<PagedResponse<List<Category>?>> GetAll(GetAll request);
}
