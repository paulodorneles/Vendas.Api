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
    public class PedidoRepository : BaseRepository<PedidoEntity>, IPedidoRepository
    {
        public PedidoRepository(MyContext context) : base(context)
        {

        }

        public async Task<List<PedidoEntity>> SelectListVendasAsync()
        {
            string query = "select * from vendas ";
            List<PedidoEntity> pedidoEntity = new List<PedidoEntity>();
            using (var conexao = new MySqlConnection(StringConection.conection))
            {
                pedidoEntity = conexao.Query<PedidoEntity>(query).ToList();
            }
            foreach (PedidoEntity v in pedidoEntity)
            {
                v.PedidoItemEntity = await SelectListVendasItens(v.Ped_Id.ToString());             
            }
            return pedidoEntity;
        }

        private async Task<List<PedidoItemEntity>> SelectListVendasItens(String pCodVendas)
        {
            string query = "select * from vendasitens WHERE Vei_IdVendas = '" + pCodVendas + "'";
            List<PedidoItemEntity> itensEntity = new List<PedidoItemEntity>();
            using (var conexao = new MySqlConnection(StringConection.conection))
            {
                itensEntity = (await conexao.QueryAsync<PedidoItemEntity>(query)).ToList();
            }
            return itensEntity;  
        }       
    }
}
