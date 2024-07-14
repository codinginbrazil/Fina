using Core.Models;
using Core.Requests.Categories;

namespace Core.Interfaces.Repositories.Categories;

public interface ICommandRepository
{
    Task<Response<Category?>> Create(Create request);
    Task<Response<Category?>> Update(Update request);
    Task<Response<Category?>> Delete(Delete request);
}
