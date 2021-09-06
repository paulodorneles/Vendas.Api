using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Dtos;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;

namespace Api.Data.Implementations
{
    public class ProdutoRepository : BaseRepository<ProdutoEntity>, IProdutoRepository
    {
        string query;

        public ProdutoRepository(MyContext context) : base(context)
        {

        }

        public async Task<List<ProdutoEntity>> SelectListProdutoAsync()
        {
            query = "select * from produto WHERE Pro_Situacao = 1 ";
            List<ProdutoEntity> produtoEntity = new List<ProdutoEntity>();
            using (var conexao = new MySqlConnection(StringConection.conection))
            {
                produtoEntity = (await conexao.QueryAsync<ProdutoEntity>(query)).ToList();
            }
            return produtoEntity;
        }
        
    }
}
