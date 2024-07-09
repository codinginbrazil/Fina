using System.ComponentModel.DataAnnotations;

namespace Core.Requests.Transactions;

public sealed class Update : Request
{
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria inválida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data inválido")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
