using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UsuarioEntity> Get(int id);
        Task<IEnumerable<UsuarioEntity>> GetAll();
        Task<UsuarioEntity> Post(UsuarioEntity user);
        Task<UsuarioEntity> Put(UsuarioEntity user);
        Task<bool> Delete(UsuarioEntity user);
        string ValidarUsuario(UsuarioEntity user);
    }
}
