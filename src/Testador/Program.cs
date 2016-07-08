using Factory;
using Servicos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testador
{
    class Program
    {
        static void Main(string[] args)
        {
            InserirCliente();
        }

        private static void InserirCliente()
        {
            Dictionary<string, object> dados = new Dictionary<string, object>();
            dados.Add("Codigo", Guid.NewGuid());
            dados.Add("Nome", "Ricardo Vicentini");
            dados.Add("LoginAcesso", "ricardo");
            dados.Add("Senha", "123456");
            dados.Add("DataCadastro", DateTime.Now);
            dados.Add("Nascimento", new DateTime(1977, 06, 16));
            dados.Add("Genero", 'M');

            string nomeBanco = ConfigurationManager.AppSettings["banco"].ToString();

            ClienteServico servico = new ClienteServico(Repositorio.ObterRepositorio(nomeBanco));

            servico.AdicionarCliente(dados);


        }
    }
}
