using Core.Requests.Transactions;

namespace Core.Interfaces.Repositories.Transactions;

public interface ICommandRepository
{
    Task<Response<Models.Transaction>> Create(Create request);
    Task<Response<Models.Transaction>> Update(Update request);
    Task<Response<Models.Transaction>> Delete(Delete request);
}