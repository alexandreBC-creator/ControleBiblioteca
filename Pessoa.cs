using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleBiblioteca {
    class Pessoa {
        public int idpessoa { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNasc { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int idendereco { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }

        public Pessoa() {

        }

        public Pessoa(string nome, string cpf, DateTime dataNasc, string telefone, string email, string logradouro, string numero, string bairro, string estado, string cidade) {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNasc = dataNasc;
            this.telefone = telefone;
            this.email = email;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.estado = estado;
            this.cidade = cidade;

        }

        public Pessoa(string nome, string cpf, DateTime dataNasc, string telefone, string email, string logradouro, string numero, string bairro, string estado, string cidade, int idpessoa, int idendereco) {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNasc = dataNasc;
            this.telefone = telefone;
            this.email = email;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.estado = estado;
            this.cidade = cidade;
            this.idpessoa = idpessoa;
            this.idendereco = idendereco;

        }

        public string insert() {
            Conexao c = new Conexao();
            try {
                c.abreConexao();

                MySqlCommand cmd = new MySqlCommand(
                    @"", c.conexaoBD());

                //Dados gerais da pessoa
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@dataNasc", this.dataNasc);
                cmd.Parameters.AddWithValue("@telefone", this.telefone);
                cmd.Parameters.AddWithValue("@email", this.email);
                //Endereço da pessoa
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@numero", this.numero);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@cidade", this.cidade);
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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cad_pessoas", conexao.conexaoBD());
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
                //Dados gerais da pessoa
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@dataNasc", this.dataNasc);
                cmd.Parameters.AddWithValue("@telefone", this.telefone);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.Parameters.AddWithValue("@idpessoa", this.idpessoa);
                //Endereço da pessoa
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@numero", this.numero);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@idendereco", this.idendereco);
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
                cmd.Parameters.AddWithValue("@idendereco", idendereco);
                cmd.Parameters.AddWithValue("@idpessoa", idpessoa);
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
