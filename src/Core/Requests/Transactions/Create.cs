using System.ComponentModel.DataAnnotations;

namespace Core.Requests.Transactions;

public sealed class Create : Request
{
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria inválida")]
    public long Categoryld { get; set; }

    [Required(ErrorMessage = "Data inválido")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
