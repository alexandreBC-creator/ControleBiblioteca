using System;
using MySql.Data.MySqlClient;

namespace ControleBiblioteca {

    class Conexao {
        string strConexao = @"SERVER=localhost; DATABASE=bdfinanceiro; UID=root; PASSWORD=123;";

        private MySqlConnection con;

        public string abreConexao() {
            try {
                con = new MySqlConnection(strConexao);
                con.Open();
                return "Ok";
            }
            catch (Exception erro) {
                return erro.Message;
            }
        }

        public string fechaConexao() {
            try {
                con = new MySqlConnection(strConexao);
                con.Close();
                return "Ok";
            }
            catch (Exception erro) {
                return erro.Message;
            }
        }

        public MySqlConnection conexaoBD() {
            return con;
        }
    }
}
