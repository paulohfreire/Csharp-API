using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    //Aqui são as informações que o usuário vai estar enviando  a API e garantir que vai enviar corretamente.
    public class UserDtoCreate
    {
        [Required (ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength (60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-mail é um campo obrigatório")]
        [EmailAddress (ErrorMessage = "Formato inválido de e-mail")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
