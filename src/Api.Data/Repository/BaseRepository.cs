using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Api.Data.Repository
{
    //public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    public class BaseRepository<T> : IRepository<T> where T : class
    {

        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(T item)
        {
            try
            {
                // var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                // if (result == null)
                //     return false;

                _dataset.Remove(item);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                //  if (item.Id == 0)
                //  {
                //  item.Id = Int32.NewGuid();
                //  }

                //  item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<bool> ExistAsync(int id)
        {
            var result = await _dataset.FindAsync(id);
            if (result == null)
                return false;
            else
                return true;
            //  return await _dataset.FindAsync._context(id);
            //  return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                // return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                return await _dataset.FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                // var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                // if (result == null)
                //     return null;
                //  item.UpdateAt = DateTime.UtcNow;
                //  item.CreateAt = result.CreateAt;
                //   _context.Entry(result).CurrentValues.SetValues(item);

                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public int ProximoCodigo(string tabela, string campo)
        {
            int idCodigo = 0;
            using (MySqlConnection conn = new MySqlConnection(StringConection.conection))
            {
                string query;
                conn.Open();
                query = "Select MAX(" + campo + ") as Codigo ";
                query += " FROM " + tabela + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Codigo"].ToString() == "")
                    {
                        idCodigo = 1;
                    }
                    else
                    {
                        idCodigo = Convert.ToInt32(dr["Codigo"].ToString()) + 1;
                    }
                }
            }
            return idCodigo;
        }
    }
}
