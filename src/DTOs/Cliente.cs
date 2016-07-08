using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Cliente
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public string LoginAcesso { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime Nascimento { get; set; }
        public char Genero { get; set; }


    }
}
