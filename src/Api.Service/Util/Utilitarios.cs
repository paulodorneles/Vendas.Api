using MySql.Data.MySqlClient;
using System;

namespace Api.Service.Util
{
    public class Utilitarios
    {
        public string ObterHashMD5(string senha)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            //     var md5 = MD5.Create();
            byte[] md5bytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] md5hashBytes = md5.ComputeHash(md5bytes);

            string senhacripto = string.Empty;
            foreach (var item in md5hashBytes)
                senhacripto += item.ToString("X2");

            return senhacripto;
        }

        /*   public int ProximoCodigo(string tabela, string campo)
           {
               int idCodigo = 0;
               using (MySqlConnection conn = new MySqlConnection(StringConexao()))
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
           }   */
    }
}
