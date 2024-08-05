using Core.Configurations.Enums;

namespace Core.Models;

public sealed class Transaction : Model
{
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }    

    public ETransactionType Type {get; set; } = ETransactionType.Withdraw;
    public decimal Amount { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string? UserId{ get; set; }  
}
