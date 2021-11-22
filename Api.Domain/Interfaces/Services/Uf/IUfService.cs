
using Api.Domain.Dtos.Uf;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Uf
{
    public interface IUfService
    {
        Task<UfDto> Get(Guid Id);
        Task<IEnumerable<UfDto>> GetAll();
    }
}
