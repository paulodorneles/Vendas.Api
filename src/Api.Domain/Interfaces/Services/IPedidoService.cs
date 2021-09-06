using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services
{
    public interface IPedidoService
    {
        Task<PedidoEntity> Get(int id);
        Task<IEnumerable<PedidoEntity>> GetAll();
        Task<PedidoEntity> Post(PedidoEntity entity);        
        Task<PedidoEntity> Put(PedidoEntity entity);
        Task<bool> Delete(PedidoEntity entity);
        Task<IEnumerable<PedidoEntity>> ListPedidos();

    }
}
