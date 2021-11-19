using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Dtos.Cep
{
    public class CepDto
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }       
        public string Logradouro { get; set; }
        public string Numero { get; set; }       
        public Guid MunicipioId { get; set; }
        public MunicipioEntity Municipio { get; set; }
    }
}
