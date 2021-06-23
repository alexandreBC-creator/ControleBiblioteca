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
    public partial class FormAluguel : Form {

        int indexSelecionadoAluguel;

        public FormAluguel() {
            InitializeComponent();
        }

        public void buscaAlugueis() {

        }

        private void btnNovoAluguel_Click(object sender, EventArgs e) {
            indexSelecionadoAluguel = -1;
            btnSalvarAluguel.Text = "Cadastrar";
            cmbPessoa.Text = string.Empty;
            cmbLivroAlugado.Text = string.Empty;
            txtDataSaida.Value = DateTime.Now;
            txtDataRetorno.Value = DateTime.Now;
            txtValor.Text = string.Empty;

            tabControl1.SelectedTab = tabControl1.TabPages["tabAluguel"];
            cmbPessoa.Focus();
        }

        private void btnSalvarAluguel_Click(object sender, EventArgs e) {
            if (cmbPessoa.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Selecione uma pessoa!");
                cmbPessoa.Focus();
            } else if (cmbLivroAlugado.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Selecione um livro!");
                cmbLivroAlugado.Focus();
            } else if (txtValor.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Insira um valor!");
                txtValor.Focus();
            } else if (txtDataRetorno.Value < txtDataSaida.Value) {
                MessageBox.Show("Data de retorno não pode ser menor do que entrada!");
            }
            else {
                Aluguel a = new Aluguel();
                if (indexSelecionadoAluguel == -1) {
                    a.insert();
                }
                else {
                    a.idaluguel = indexSelecionadoAluguel;
                    a.update();
                }

                buscaAlugueis();
                tabControl1.SelectedTab = tabControl1.TabPages["tabAlugueisCadastrados"];
            }
        }
    }
}
