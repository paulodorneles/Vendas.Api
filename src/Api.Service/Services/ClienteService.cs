using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(ClienteEntity entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<ClienteEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ClienteEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ClienteEntity> Post(ClienteEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<ClienteEntity> Put(ClienteEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<ClienteEntity>> ListCliente()
        {
            return await _repository.SelectListClienteAsync();
        }        
    }
}
