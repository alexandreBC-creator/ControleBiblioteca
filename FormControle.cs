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
    public partial class FormControle : Form {

        int indexSelecionadoPessoa;
        int indexSelecionadoLivro;
        int indexSelecionadoAluguel;

        public FormControle() {
            InitializeComponent();
        }

        public void buscaLivros() {
            
        }

        public void buscaPessoas() {

        }

        public void buscaAlugueis() {

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

            //tabControl1.TabPages.Add(tabPessoas);
            //tabControl1.TabPages.Remove(tabPessoasCadastradas);

            txtNome.Focus();
        }

        private void btnNovoLivro_Click(object sender, EventArgs e) {
            indexSelecionadoLivro = -1;
            btnSalvarLivro.Text = "Cadastrar";
            txtDescricaoLivro.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDataEntrada.Value = DateTime.Now;

            //tabControl1.TabPages.Add(tabLivros);
            //tabControl1.TabPages.Remove(tabLivrosCadastrados);

            txtDescricaoLivro.Focus();
        }

        private void btnNovoAluguel_Click(object sender, EventArgs e) {
            indexSelecionadoAluguel = -1;
            btnSalvarAluguel.Text = "Cadastrar";
            cmbPessoa.Text = string.Empty;
            cmbLivroAlugado.Text = string.Empty;
            txtDataSaida.Value = DateTime.Now;
            txtDataRetorno.Value = DateTime.Now;
            txtValor.Text = string.Empty;

            //tabControl1.TabPages.Add(tabAluguel);
            //tabControl1.TabPages.Remove(tabAlugueisCadastrados);

            cmbPessoa.Focus();
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e) {
            if (txtNome.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o nome da pessoa!");
                txtNome.Focus();
            } 
            else {
                FormPessoas p = new FormPessoas();
                if (indexSelecionadoPessoa == -1) {
                p.insert();
                } 
                else {
                p.idpessoa = indexSelecionadoPessoa;
                p.update();
                }

                buscaPessoas();
                tabControl1.TabPages.Add(tabPessoasCadastradas);
                tabControl1.TabPages.Remove(tabPessoas);
            }
            
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e) {
            if (txtNome.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite uma descrição.");
                txtNome.Focus();
            }
            else {
                FormLivros l = new FormLivros();
                if (indexSelecionadoLivro == -1) {
                    l.insert();
                }
                else {
                    l.idlivro = indexSelecionadoLivro;
                    l.update();
                }

                buscaLivros();
                tabControl1.TabPages.Add(tabLivrosCadastrados);
                tabControl1.TabPages.Remove(tabLivros);
            }
        }

        private void btnSalvarAluguel_Click(object sender, EventArgs e) {
            if (txtNome.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite uma descrição.");
                txtNome.Focus();
            }
            else {
                FormAluguel a = new FormAluguel();
                if (indexSelecionadoAluguel == -1) {
                    a.insert();
                }
                else {
                    a.idaluguel = indexSelecionadoAluguel;
                    a.update();
                }

                buscaAlugueis();
                tabControl1.TabPages.Add(tabAlugueisCadastrados);
                tabControl1.TabPages.Remove(tabAluguel);
            }
        }
    }
}
