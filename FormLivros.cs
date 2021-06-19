using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleBiblioteca {
    class FormLivros {
        public int idlivro { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public DateTime dataentrada { get; set; }
        public string autor { get; set; }

        public FormLivros() {

        }

        public FormLivros(string descricao, string autor, DateTime dataentrada, string categoria) {
            this.descricao = descricao;
            this.autor = autor;
            this.dataentrada = dataentrada;
            this.categoria = categoria;
        }
        public FormLivros(string descricao, string autor, DateTime dataentrada, string categoria, int idlivro) {
            this.descricao = descricao;
            this.autor = autor;
            this.dataentrada = dataentrada;
            this.categoria = categoria;
            this.idlivro = idlivro;
        }


        public string insert() {
            FormConexao c = new FormConexao();
            try {
                c.abreConexao();

                MySqlCommand cmd = new MySqlCommand(
                    @"", c.conexaoBD());

                cmd.Parameters.AddWithValue("@idpessoa", this.descricao);
                cmd.Parameters.AddWithValue("@autor", this.autor);
                cmd.Parameters.AddWithValue("@dataentrada", this.dataentrada);
                cmd.Parameters.AddWithValue("@idendereco", this.categoria);
                cmd.ExecuteNonQuery();
                return "Ok";
            }
            catch (Exception erro) {
                return erro.Message;
            }
            finally {
                c.fechaConexao();
            }
        }

        public DataTable select() {
            DataTable tabela = new DataTable();
            FormConexao conexao = new FormConexao();
            try {
                conexao.abreConexao();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cad_livros", conexao.conexaoBD());
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows == true) {
                    tabela.Load(dados);
                }
                else {
                    tabela = new DataTable("Erro");
                    tabela.Rows.Add("Nenhuma movimentação encontrada");
                }
                return tabela;
            }
            catch (Exception erro) {
                tabela = new DataTable("Erro");
                tabela.Rows.Add("Erro: " + erro.Message);
                return tabela;
            }
            finally {
                conexao.fechaConexao();
            }
        }


        public string update() {

            FormConexao c = new FormConexao();
            try {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand(@"", c.conexaoBD());
                cmd.Parameters.AddWithValue("@idpessoa", this.descricao);
                cmd.Parameters.AddWithValue("@autor", this.autor);
                cmd.Parameters.AddWithValue("@dataentrada", this.dataentrada);
                cmd.Parameters.AddWithValue("@idendereco", this.categoria);
                cmd.Parameters.AddWithValue("@idaluguel", this.idlivro);
                cmd.ExecuteNonQuery();
                return "Movimentação atualizada com sucesso!";
            }
            catch (Exception erro) {
                return "Erro: " + erro.Message;
            }
            finally {
                c.fechaConexao(); ;
            }


        }

        public string delete(int codigo) {

            FormConexao c = new FormConexao();
            try {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand(@"", c.conexaoBD());
                cmd.Parameters.AddWithValue("@idaluguel", idlivro);
                cmd.ExecuteNonQuery();
                return "Movimentação excluida com sucesso!";

            }
            catch (Exception erro) {
                return "Erro: " + erro.Message;
            }
            finally {
                c.fechaConexao();
            }
        }
    }
}
