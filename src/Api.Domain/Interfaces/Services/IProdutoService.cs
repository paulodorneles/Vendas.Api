using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<ProdutoEntity> Get(int id);
        Task<IEnumerable<ProdutoEntity>> GetAll();
        Task<ProdutoEntity> Post(ProdutoEntity entity);        
        Task<ProdutoEntity> Put(ProdutoEntity entity);
        Task<bool> Delete(ProdutoEntity entity);
        Task<IEnumerable<ProdutoEntity>> ListProduto();
    }
}
