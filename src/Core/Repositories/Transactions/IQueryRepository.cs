using Core.Requests.Transactions;

namespace Core.Repositories.Transactions;

public interface IQueryRepository
{
    Task<Response<IEnumerable<Models.Transaction>>> GetAll();
    Task<Response<Models.Transaction?>> GetById(GetById request);
    Task<PagedResponse<IEnumerable<Models.Transaction>?>> GetByPeriod(GetByPeriod request);
}