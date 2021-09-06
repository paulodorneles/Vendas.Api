using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(CategoriaEntity entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<CategoriaEntity> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CategoriaEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CategoriaEntity> Post(CategoriaEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<CategoriaEntity> Put(CategoriaEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<CategoriaEntity>> ListCategoria()
        {
            return await _repository.SelectListCategoriaAsync();
        }        
    }
}