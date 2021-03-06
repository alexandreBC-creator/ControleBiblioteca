using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleBiblioteca {
    class Livro {
        public int idlivro { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public DateTime dataentrada { get; set; }
        public string autor { get; set; }

        public Livro() {

        }

        public Livro(string descricao, string autor, DateTime dataentrada, string categoria) {
            this.descricao = descricao;
            this.autor = autor;
            this.dataentrada = dataentrada;
            this.categoria = categoria;
        }
        public Livro(string descricao, string autor, DateTime dataentrada, string categoria, int idlivro) {
            this.descricao = descricao;
            this.autor = autor;
            this.dataentrada = dataentrada;
            this.categoria = categoria;
            this.idlivro = idlivro;
        }


        public string insert() {
            Conexao c = new Conexao();
            try {
                c.abreConexao();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO ControleBiblioteca.cad_livros"
                    + "(descricao, categoria, autor, dataentrada, ativo)"
                    + "VALUES(@descricao, @categoria, @autor, @dataentrada, true)"
                , c.conexaoBD());

                cmd.Parameters.AddWithValue("@descricao", this.descricao);
                cmd.Parameters.AddWithValue("@categoria", this.categoria);
                cmd.Parameters.AddWithValue("@autor", this.autor);
                cmd.Parameters.AddWithValue("@dataentrada", this.dataentrada);
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
            Conexao conexao = new Conexao();
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

            Conexao c = new Conexao();
            try {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_livros SET descricao=@descricao, categoria=@categoria, autor=@autor, dataentrada=@dataentrada, ativo=1 WHERE idlivro=@idlivro", c.conexaoBD());
                cmd.Parameters.AddWithValue("@descricao", this.descricao);
                cmd.Parameters.AddWithValue("@categoria", this.categoria);
                cmd.Parameters.AddWithValue("@autor", this.autor);
                cmd.Parameters.AddWithValue("@dataentrada", this.dataentrada);
                cmd.Parameters.AddWithValue("@idlivro", this.idlivro);
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

            Conexao c = new Conexao();
            try {
                c.abreConexao();
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_livros SET ativo=false "
                    + " WHERE idlivro= " + codigo
                 , c.conexaoBD());

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
