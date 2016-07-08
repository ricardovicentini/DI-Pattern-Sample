using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class ClienteServico
    {
        private IRepositorio banco;
        public ClienteServico(IRepositorio repositorio)
        {
            banco = repositorio;
        }

        public void AdicionarCliente(Dictionary<string,object> dadosCliente)
        {
            banco.InserirRegistro("cliente", dadosCliente);
        }
    }
}
