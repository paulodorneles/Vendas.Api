using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Util;
using AutoMapper;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UsuarioEntity> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<UsuarioEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
        public async Task<UsuarioRetornoDto> Post(UsuarioDto user)
        {
            Utilitarios util = new Utilitarios();
            var entity = _mapper.Map<UsuarioEntity>(user);
            entity.Usu_Senha = util.ObterHashMD5(user.Usu_Senha);
            entity.Usu_Id = _repository.ProximoCodigo("usuario","Usu_Id");
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<UsuarioRetornoDto>(result);
        }
        public async Task<UsuarioEntity> Put(UsuarioEntity user)
        {
            return await _repository.UpdateAsync(user);
        }

        public string ValidarUsuario(UsuarioDto user) {
            string retorno = "";
            if (user.Usu_Senha != user.Usu_SenhaConfirmar) {
                retorno = "Senha e confirmação de senha não confere";
            }
            return retorno;
        }

    }
}
