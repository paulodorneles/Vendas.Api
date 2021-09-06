using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<ClienteEntity> Get(int id);
        Task<IEnumerable<ClienteEntity>> GetAll();
        Task<ClienteEntity> Post(ClienteEntity entity);        
        Task<ClienteEntity> Put(ClienteEntity entity);
        Task<bool> Delete(ClienteEntity entity);
        Task<IEnumerable<ClienteEntity>> ListCliente();
    }
}
