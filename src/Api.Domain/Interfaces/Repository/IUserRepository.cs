using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> FindByLogin(string email, string senha);        
    }
}
