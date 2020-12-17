using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jefter.Negociacao_B3.Dominio;
using Jefter.Negociacao_B3.Negocios;

namespace Jefter.Negociacao_B3.Visualizacao
{
    public partial class CadClientes : Form
    {
        UsuarioDominio objClientes = new UsuarioDominio();

        public CadClientes()
        {
            InitializeComponent();
        }

        private string opcoes = "";

        private void IniciarOpcoes()
        {
            switch (opcoes)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        if (txtNomeCliente.Text = "" | txtCPF.Text == "" | txtTelefone.Text == "" | txtEndereco.Text == "" | txtBairro.Text == "" | txtCidade.Text == "" | txtUF.Text == "")
                        {
                            MessageBox.Show("Por favor, preencha todos os campos!");
                            txtNomeCliente.Focus();
                            return;
                        }

                        objClientes.Nome_cliente = txtNomeCliente.Text;
                        objClientes.Cpf = txtCPF.Text;
                        objClientes.Telefone = txtTelefone.Text;
                        objClientes.Endereco = txtEndereco.Text;
                        objClientes.Bairro = txtBairro.Text;
                        objClientes.Cidade = txtCidade.Text;
                        objClientes.Uf = txtUF.Text;

                        int x = UsuarioNegocios.Inserir(objClientes);

                        if(x > 0)
                        {
                            MessageBox.Show(string.Format("Cliente {0} inserido com suacesso!", txtNomeCliente.Text));
                            DesabilitarCampos();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não inserido!");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu um erro ao salvar " + ex.Message);
                    }
                    break;
            }
        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opcoes = "Novo";
            IniciarOpcoes();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtCodigoCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCPF.Enabled = true;
            txtTelefone.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtCodigoCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCPF.Enabled = false;
            txtTelefone.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
        }
    }
}
