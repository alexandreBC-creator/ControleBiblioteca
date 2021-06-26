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

namespace ControleBiblioteca
{
    class Pessoa
    {
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
        public string cep { get; set; }
        public int idcontato { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, DateTime dataNasc, string telefone, string email, string logradouro, string numero, string bairro, string estado, string cidade,string cep)
        {
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
            this.cep = cep;
        }

        public Pessoa(string nome, string cpf, DateTime dataNasc, string telefone, string email, string logradouro, string numero, string bairro, string estado, string cidade, int idpessoa, int idendereco)
        {
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

        public string insert()
        {
            Conexao c = new Conexao();
            try
            {
                c.abreConexao();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO ControleBiblioteca.cad_pessoas"
                    + "(nome, cpf, datanasc) "
                    + "VALUES(@nome,@cpf, @dataNasc) "
                , c.conexaoBD());

                //Dados gerais da pessoa
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@dataNasc", this.dataNasc);

                cmd.ExecuteNonQuery();

                
;
                cmd = new MySqlCommand("SELECT LAST_INSERT_ID() as ultimo ", c.conexaoBD());
                MySqlDataReader dados = cmd.ExecuteReader();
                
                int last_id = 0;

                if (dados.HasRows)
                {
                    last_id = dados.GetInt32(dados.GetOrdinal("ultimo"));
                }
                else
                {
                    return "Falha na obtenção do ultimo ID";
                }

                cmd = new MySqlCommand("INSERT INTO ControleBiblioteca.cad_contatos "
                + "(telefone, email, idpessoa, principal) "
                + "VALUES(@telefone, @email, @idpessoa, true)", c.conexaoBD());
                cmd.Parameters.AddWithValue("@telefone", this.telefone);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.Parameters.AddWithValue("@idpessoa", last_id);

                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("SELECT LAST_INSERT_ID() as ultimo ", c.conexaoBD());
                dados = cmd.ExecuteReader();

                int last_id_contact = 0;

                if (dados.HasRows)
                {
                    last_id_contact = dados.GetInt32(dados.GetOrdinal("ultimo"));
                }
                else
                {
                    return "Falha na obtenção do ultimo ID do Contato";
                }

                cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_pessoas SET idcontato = @idcontato, WHERE idpessoa= @idpessoa", c.conexaoBD());

                cmd.Parameters.AddWithValue("@idcontato", last_id_contact);
                cmd.Parameters.AddWithValue("@idpessoa", last_id);


                cmd = new MySqlCommand("INSERT INTO ControleBiblioteca.cad_enderecos"
                + "(logradouro, bairro, numero, estado, cidade, cep, idpessoa)"
                + "VALUES(@logradouro,@bairro,@numero, @estado, @cidade, @cep, @idpessoa)", c.conexaoBD());

                //Endereço da pessoa
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@numero", this.numero);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@cep", this.cep);
                cmd.Parameters.AddWithValue("@cidade", this.cidade);
                cmd.Parameters.AddWithValue("@idpessoa", last_id);

                cmd = new MySqlCommand("SELECT LAST_INSERT_ID() as ultimo ", c.conexaoBD());
                dados = cmd.ExecuteReader();

                int last_id_address = 0;

                if (dados.HasRows)
                {
                     = dados.GetInt32(dados.GetOrdinal("ultimo"));
                }
                else
                {
                    return "Falha na obtenção do ultimo ID do Endereço";
                }

                cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_pessoas SET idendereco = @idendereco, WHERE idpessoa= @idpessoa", c.conexaoBD());

                cmd.Parameters.AddWithValue("@idendereco", last_id_address);
                cmd.Parameters.AddWithValue("@idpessoa", last_id);

                return "Ok";
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
            finally
            {
                c.fechaConexao();
            }
        }

        public DataTable select()
        {
            DataTable tabela = new DataTable();
            Conexao conexao = new Conexao();
            try
            {
                conexao.abreConexao();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cad_pessoas", conexao.conexaoBD());
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows == true)
                {
                    tabela.Load(dados);
                }
                else
                {
                    tabela = new DataTable("Erro");
                    tabela.Rows.Add("Nenhuma movimentação encontrada");
                }
                return tabela;
            }
            catch (Exception erro)
            {
                tabela = new DataTable("Erro");
                tabela.Rows.Add("Erro: " + erro.Message);
                return tabela;
            }
            finally
            {
                conexao.fechaConexao();
            }
        }


        public string update()
        {

            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_pessoas SET nome=@nome, " +
                    " cpf=@cpf, datanasc=@dataNasc, WHERE idpessoa= @idpessoa", c.conexaoBD());
                //Dados gerais da pessoa
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@dataNasc", this.dataNasc);
                cmd.Parameters.AddWithValue("@idpessoa", this.idpessoa);

                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_contatos SET telefone=@telefone, email=@email," + " WHERE idcontato=@idcontato"
                , c.conexaoBD());


                cmd.Parameters.AddWithValue("@telefone", this.telefone);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.Parameters.AddWithValue("@idcontato", this.idcontato);

                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_enderecos SET logradouro=@logradouro,bairro=@bairro,"
                    + "numero=@numero, estado=@estado, cidade=@cidade, cep=@cep, WHERE idendereco=@idendereco"
                , c.conexaoBD());
                //Endereço da pessoa
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@numero", this.numero);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@cidade", this.cidade);
                cmd.Parameters.AddWithValue("@cep", this.cep);
                cmd.Parameters.AddWithValue("@idendereco", this.idendereco);

                cmd.ExecuteNonQuery();

                return "Movimentação atualizada com sucesso!";
            }
            catch (Exception erro)
            {
                return "Erro: " + erro.Message;
            }
            finally
            {
                c.fechaConexao(); ;
            }


        }

        public string inativar(int codigo)
        {

            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("UPDATE ControleBiblioteca.cad_pessoas SET ativo=false "
                    + " WHERE idpessoa= " + this.idpessoa
                 , c.conexaoBD()) ;


                cmd.ExecuteNonQuery(); 
                
                return "Pessoa desativada com sucesso!";

            }
            catch (Exception erro)
            {
                return "Erro: " + erro.Message;
            }
            finally
            {
                c.fechaConexao();
            }
        }
    }
}
