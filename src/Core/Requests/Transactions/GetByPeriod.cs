namespace Core.Requests.Transactions;

public sealed class GetByPeriod : PagedRequest
{
    public DateTime? StartDate { get; set; } 
    public DateTime? EndDate { get; set; } 
}
