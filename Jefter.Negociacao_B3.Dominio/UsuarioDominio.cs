using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jefter.Negociacao_B3.Dominio
{
    public class UsuarioDominio
    {
        private int codigo_cliente;
        private string nome_cliente;
        private string cpf;
        private string telefone;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;

        public int Codigo_cliente { get => codigo_cliente; set => codigo_cliente = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}
