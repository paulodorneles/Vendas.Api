using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Dapper;
using System.Collections.Generic;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UsuarioEntity>, IUserRepository
    {
        private DbSet<UsuarioEntity> _dataset;
        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = _context.Set<UsuarioEntity>();
        }

        public async Task<UsuarioEntity> FindByLogin(string email, string senha)
        {
            var query = "select";
            query += " usu.nome, usu.email, banco as emp, usu.id, usu.vendedor_id ";
            query += "   FROM usuarios usu ";
            query += "   LEFT JOIN clientes cli ON cli.id = usu.cliente_id   ";
            query += "    WHERE usu.email = '" + email + "' AND  ";
            query += "        usu.senha = '" + senha + "' ";
           
            using (var conexao = new MySqlConnection(StringConection.conection))
            {                
                return await conexao.QuerySingleAsync<UsuarioEntity>(query);               
            }            
        }
    }
}
