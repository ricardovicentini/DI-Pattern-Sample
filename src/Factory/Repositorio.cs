using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class Repositorio
    {
        public static IRepositorio ObterRepositorio(string nomeRepositorio)
        {
            switch (nomeRepositorio)
            {
                case "SqlServer":
                    return new RepositorioSQLServer.SqlServer();
                default:
                    return null;
            }
        }
    }
}
