using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Municipio
{
    public interface IMunicipioService
    {
        Task<MunicipioDto> Get(Guid Id);
        Task<MunicipioDtoCompleto> GetCompleteById(Guid Id);
        Task<MunicipioDtoCompleto> GetCompleteByIBGE(int codIBGE);
        Task<IEnumerable<MunicipioDto>> GetAll();
        Task<MunicipioDtoCreateResult> Post(MunicipioDtoCreate municipio);
        Task<MunicipioDtoCreateResult> Put(MunicipioDtoUpdate municipio);
        Task<bool> Delete(Guid Id);

    }
}
