using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UsuarioEntity> Get(int id);
        Task<IEnumerable<UsuarioEntity>> GetAll();
        Task<UsuarioRetornoDto> Post(UsuarioDto user);
        Task<UsuarioEntity> Put(UsuarioEntity user);
        Task<bool> Delete(UsuarioEntity user);
        string ValidarUsuario(UsuarioDto user);
    }
}
