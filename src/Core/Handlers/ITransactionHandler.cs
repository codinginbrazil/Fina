using Core.Requests.Transactions;

namespace Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> Create(Create request);
    Task<Response<Transaction?>> Update(Update request);
    Task<Response<Transaction?>> Delete(Delete request);
    Task<Response<Transaction?>> GetById(GetById request);
    Task<PagedResponse<List<Transaction>?>> GetByPeriod(GetByPeriod request);
}