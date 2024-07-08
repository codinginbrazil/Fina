using System.ComponentModel.DataAnnotations;

namespace Core.Requests.Categories;

public sealed class Update : Request
{
    public long Id  { get; set; }

    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválido")]
    public string? Description { get; set; } = string.Empty;
}