using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(ProdutoEntity entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<ProdutoEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ProdutoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ProdutoEntity> Post(ProdutoEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<ProdutoEntity> Put(ProdutoEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<ProdutoEntity>> ListProduto()
        {
            return await _repository.SelectListProdutoAsync();
        }        
    }
}
