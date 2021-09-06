using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;
using System;

namespace Api.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepository<ProdutoEntity>
    {
        Task<List<ProdutoEntity>> SelectListProdutoAsync();        
    }
}
