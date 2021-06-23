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
    public partial class FormLivro : Form {

        int indexSelecionadoLivro;

        public FormLivro() {
            InitializeComponent();
        }

        public void buscaLivros() {
            
        }

        private void btnNovoLivro_Click(object sender, EventArgs e) {
            indexSelecionadoLivro = -1;
            btnSalvarLivro.Text = "Cadastrar";
            txtDescricaoLivro.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDataEntrada.Value = DateTime.Now;

            tabControl1.SelectedTab = tabControl1.TabPages["tabLivros"];
            txtDescricaoLivro.Focus();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e) {
            if (txtDescricaoLivro.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite uma descrição para o livro!");
                txtDescricaoLivro.Focus();
            } else if (txtAutor.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite o autor do livro.");
                txtDescricaoLivro.Focus();
            } else if (txtCategoria.Text.Trim().Equals(string.Empty)) {
                MessageBox.Show("Digite a categoria do livro!");
                txtDescricaoLivro.Focus();
            }
            else {
                Livro l = new Livro();
                if (indexSelecionadoLivro == -1) {
                    l.insert();
                }
                else {
                    l.idlivro = indexSelecionadoLivro;
                    l.update();
                }

                buscaLivros();
                tabControl1.SelectedTab = tabControl1.TabPages["tabLivrosCadastrados"];
            }
        }

    }
}
