using Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioSQLServer
{
    public class SqlServer : IRepositorio
    {
        

        public void InserirRegistro(string nomeTabela, Dictionary<string, object> dados)
        {
            string strConexao = ConfigurationManager.ConnectionStrings["conexaoSql"].ConnectionString;
            using (System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection(strConexao))
            {
                string comando = GerarComandoInsert(nomeTabela, dados);
                SqlCommand cmd = new SqlCommand(comando, cnn);
                AdicionarParametrosSql(cmd, dados);
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void AdicionarParametrosSql(SqlCommand cmd, Dictionary<string, object> dados)
        {
            
            foreach (var item in dados)
            {
                cmd.Parameters.Add(new SqlParameter("@" + item.Key, item.Value));
            }
            
        }
        private string GerarComandoInsert(string nomeTabela, Dictionary<string, object> dados)
        {
            string colunas = string.Join(",", dados.Keys);
            List<string> listColunas = new List<string>();
            dados.Keys.ToList().ForEach(x => listColunas.Add( "@" + x));
            
            string valores = string.Join(",", listColunas);
            
            
            string comando = $"Insert into {nomeTabela}({colunas}) values({valores.ToString()}) ";
            return comando;
            
        }
    }
}
