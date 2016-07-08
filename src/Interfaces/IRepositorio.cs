using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepositorio
    {
        void InserirRegistro(string nomeTabela, Dictionary<string, object> dados);
    }
}
