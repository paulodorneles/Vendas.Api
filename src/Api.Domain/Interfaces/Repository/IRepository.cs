using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repository
{
    //public interface IRepository<T> where T : BaseEntity
    public interface IRepository<T> where T : class
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(T item);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);
        int ProximoCodigo(string tabela, string campo);

    }
}
