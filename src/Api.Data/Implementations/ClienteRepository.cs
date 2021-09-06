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
    public class ClienteRepository : BaseRepository<ClienteEntity>, IClienteRepository
    {        

        public ClienteRepository(MyContext context) : base(context)
        {

        }        

        public async Task<List<ClienteEntity>> SelectListClienteAsync()
        {
            String query = "select * FROM cliente 	";            
            List<ClienteEntity> clienteEntity = new List<ClienteEntity>();
            using (var conexao = new MySqlConnection(StringConection.conection))
            {
                clienteEntity = (await conexao.QueryAsync<ClienteEntity>(query)).ToList();
            }
            return clienteEntity;
        }        
    }
}
