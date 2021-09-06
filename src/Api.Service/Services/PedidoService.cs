using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class PedidoService : IPedidoService
    {
        private IPedidoRepository _repository;      

        public PedidoService(IPedidoRepository repository)
        {
            _repository = repository;            
        }

        public async Task<bool> Delete(PedidoEntity entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<PedidoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PedidoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PedidoEntity> Post(PedidoEntity entity)
        {            
            return await _repository.InsertAsync(entity);
        }

        public async Task<PedidoEntity> Put(PedidoEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<PedidoEntity>> ListPedidos()
        {
            return await _repository.SelectListVendasAsync();
        }
    }
}
