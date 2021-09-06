using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Util;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UsuarioEntity> _repository;
        public UserService(IRepository<UsuarioEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(UsuarioEntity user)
        {
            return await _repository.DeleteAsync(user);
        }
        public async Task<UsuarioEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }
        public async Task<IEnumerable<UsuarioEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }
        public async Task<UsuarioEntity> Post(UsuarioEntity user)
        {
            Utilitarios util = new Utilitarios();
            user.senha = util.ObterHashMD5(user.senha);
            user.id = _repository.ProximoCodigo("usuario","id");
            return await _repository.InsertAsync(user);
        }
        public async Task<UsuarioEntity> Put(UsuarioEntity user)
        {
            return await _repository.UpdateAsync(user);
        }

        public string ValidarUsuario(UsuarioEntity user) {
            string retorno = "";
            if (user.senha != user.confirmasenha) {
                retorno = "Senha e confirmação de senha não confere";
            }
            return retorno;
        }

    }
}
