using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleBiblioteca {
    public partial class FormPessoa : Form {

        int indexSelecionadoPessoa;

        public FormPessoa() {
            InitializeComponent();
        }

        public void buscaPessoas() {

        }

        private void btnNovoPessoa_Click(object sender, EventArgs e) {
            indexSelecionadoPessoa = -1;
            btnSalvarPessoa.Text = "Cadastrar";
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtDataNasc.Value = DateTime.Now;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;

            tabControl1.SelectedTab = tabControl1.TabPages["tabPessoas"];

            txtNome.Focus();
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e) {
            if (txtNome.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o nome da pessoa!");
                txtNome.Focus();
            } else if (txtCpf.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o CPF da pessoa!");
                txtCpf.Focus();
            } else if (txtTelefone.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o telefone da pessoa!");
                txtTelefone.Focus();
            } else if (txtEmail.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o e-mail da pessoa!");
                txtEmail.Focus();
            } else if (txtLogradouro.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o logradouro da pessoa!");
                txtLogradouro.Focus();
            } else if (txtNumero.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o número da casa/apto da pessoa!");
                txtNumero.Focus();
            } else if (txtBairro.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o bairro da pessoa!");
                txtBairro.Focus();
            } else if (txtEstado.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o estado da pessoa!");
                txtEstado.Focus();
            } else if (txtCidade.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite a cidade da pessoa!");
                txtCidade.Focus();
            }
            else {
                Pessoa p = new Pessoa();
                if (indexSelecionadoPessoa == -1) {
                p.insert();
                } 
                else {
                p.idpessoa = indexSelecionadoPessoa;
                p.update();
                }

                buscaPessoas();
                tabControl1.SelectedTab = tabControl1.TabPages["tabPessoasCadastradas"];
            }
            
        }
    }
}
