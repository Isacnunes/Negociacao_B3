using Jefter.Negociacao_B3.Dados;
using Jefter.Negociacao_B3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jefter.Negociacao_B3.Negocios
{
    public class UsuarioNegocios
    {
        public static int Inserir(UsuarioDominio objClientes)
        {
            return UsuarioDados.Inserir(objClientes);
        }
    }
}
