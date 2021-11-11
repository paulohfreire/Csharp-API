using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using System.Threading.Tasks;

namespace Api.Service
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<object> FindByLogin(UserEntity user)
        {
            if(user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                return await _repository.FindByLogin(user.Email);
            }  else
            {
                return null;
            }  
        }
    }
}
