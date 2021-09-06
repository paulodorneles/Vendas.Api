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
    public class CategoriaRepository : BaseRepository<CategoriaEntity>, ICategoriaRepository
    {
        public CategoriaRepository(MyContext context) : base(context)
        {

        }

        public async Task<List<CategoriaEntity>> SelectListCategoriaAsync()
        {
            String query = "select * from categoria ";
            List<CategoriaEntity> categoriaEntity = new List<CategoriaEntity>();
            using (var conexao = new MySqlConnection(StringConection.conection))
            {
                categoriaEntity = (await conexao.QueryAsync<CategoriaEntity>(query)).ToList();
            }
            return categoriaEntity;
        }
        
    }
}
