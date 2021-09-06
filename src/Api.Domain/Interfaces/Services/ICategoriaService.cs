using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        Task<CategoriaEntity> Get(int id);
        Task<IEnumerable<CategoriaEntity>> GetAll();
        Task<CategoriaEntity> Post(CategoriaEntity entity);        
        Task<CategoriaEntity> Put(CategoriaEntity entity);
        Task<bool> Delete(CategoriaEntity entity);    
        Task<IEnumerable<CategoriaEntity>> ListCategoria();     
    }
}