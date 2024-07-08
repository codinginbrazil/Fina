using Core.Enums;

namespace Core.Models;

public sealed class Transaction : Model
{
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }    

    public ETransctionType Type {get; set; } = ETransctionType.Withdraw;
    public decimal Amount { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string? Userld{ get; set; }  
}
