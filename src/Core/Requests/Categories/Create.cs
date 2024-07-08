using System.ComponentModel.DataAnnotations;

namespace Core.Requests.Categories;

//Flunt
//FluntValidation
public sealed class Create : Request 
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválido")]
    public string Description { get; set; } = string.Empty;
}
