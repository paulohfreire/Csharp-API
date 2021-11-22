using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoUpdate
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome de município é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="Código inválido")]
        public int CodIBGE { get; set; }
        [Required(ErrorMessage = "Código de UF é um campo obrigatório")]
        public Guid UfId { get; set; }
    }
}
