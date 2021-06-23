using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleBiblioteca {
    class Aluguel {
        public int idaluguel { get; set; }
        public int idpessoa { get; set; }
        public int idendereco { get; set; }
        public DateTime datasaida { get; set; }
        public DateTime dataretorno { get; set; }
        public double valor { get; set; }

        public Aluguel() {

        }

        public Aluguel(int idpessoa, int idendereco, DateTime datasaida, DateTime dataretorno, double valor) {
            this.idpessoa = idpessoa;
            this.idendereco = idendereco;
            this.datasaida = datasaida;
            this.dataretorno = dataretorno;
            this.valor = valor;
        }

        public Aluguel(int idpessoa, int idendereco, DateTime datasaida, DateTime dataretorno, double valor, 
            int idaluguel) {
            this.idpessoa = idpessoa;
            this.idendereco = idendereco;
            this.datasaida = datasaida;
            this.dataretorno = dataretorno;
            this.valor = valor;
            this.idaluguel = idaluguel;
        }


        public string insert() {
            Conexao c = new Conexao();
            try {
                c.abreConexao();

                MySqlCommand cmd = new MySqlCommand(
                    @"", c.conexaoBD());

                cmd.Parameters.AddWithValue("@idpessoa", this.idpessoa);
                cmd.Parameters.AddWithValue("@idendereco", this.idendereco);
                cmd.Parameters.AddWithValue("@datasaida", this.datasaida);
                cmd.Parameters.AddWithValue("@dataretorno", this.dataretorno);
                cmd.Parameters.AddWithValue("@valor", this.valor);
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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cad_alugueis", conexao.conexaoBD());
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
                MySqlCommand cmd = new MySqlCommand(@"", c.conexaoBD());
                cmd.Parameters.AddWithValue("@idpessoa", this.idpessoa);
                cmd.Parameters.AddWithValue("@idendereco", this.idendereco);
                cmd.Parameters.AddWithValue("@datasaida", this.datasaida);
                cmd.Parameters.AddWithValue("@dataretorno", this.dataretorno);
                cmd.Parameters.AddWithValue("@valor", this.valor);
                cmd.Parameters.AddWithValue("@idaluguel", this.idaluguel);
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
                MySqlCommand cmd = new MySqlCommand(@"", c.conexaoBD());
                cmd.Parameters.AddWithValue("@idaluguel", idaluguel);
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
