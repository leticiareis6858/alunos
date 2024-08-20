using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alunos
{
    public class Database
    {
        private string connectionString;

        public Database()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public void CreateTables()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS alunos;";
                MySqlCommand cmdCreateDb = new MySqlCommand(createDatabaseQuery, conn);
                cmdCreateDb.ExecuteNonQuery();

                string useDatabaseQuery = "USE alunos;";
                MySqlCommand cmdUseDb = new MySqlCommand(useDatabaseQuery, conn);
                cmdUseDb.ExecuteNonQuery();

                string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS tb_aluno (
                    matricula_aluno int NOT NULL AUTO_INCREMENT,
                    nome_aluno varchar(100) NOT NULL,
                    email_aluno varchar(45) NOT NULL UNIQUE,
                    whatsapp_aluno varchar(20) DEFAULT NULL UNIQUE,
                    senha_aluno varchar(50) NOT NULL,
                    endereco_aluno varchar(100) DEFAULT NULL,
                    cidade_aluno varchar(100) NOT NULL,
                    data_nasc_aluno varchar(10) DEFAULT NULL,
                    status_matricula_aluno ENUM('ativa', 'inativa') DEFAULT 'ativo', 
                    PRIMARY KEY (matricula_aluno)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_usuario (
                    id_usuario int NOT NULL AUTO_INCREMENT,
                    nome_usuario varchar(100) NOT NULL,
                    email_usuario varchar(100) NOT NULL UNIQUE,
                    senha_usuario varchar(100) NOT NULL,
                    PRIMARY KEY (id_usuario)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
            ";

                MySqlCommand cmdCreateTables = new MySqlCommand(createTablesQuery, conn);
                cmdCreateTables.ExecuteNonQuery();

                conn.Close();
            }
        }

        public bool VerificarLogin(String email, String senha)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_usuario WHERE email_usuario = @email AND senha_usuario = @senha";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                return count > 0;
            }
        }

        public bool VerificarNomeEmailUsuario(String email, String nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tb_usuario WHERE email_usuario = @email AND nome_usuario = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nome", nome);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                return count > 0;

            }
        }

        public bool MudarSenha(String email, String senha)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "UPDATE tb_usuario SET senha_usuario = @senha WHERE email_usuario = @email";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@email", email);

                    int resultado = cmd.ExecuteNonQuery();

                    return resultado > 0;
                }
            }
        }

        public bool CadastrarUsuario(String nome, String email, String senha)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query="INSERT INTO tb_usuario(nome_usuario, email_usuario, senha_usuario) VALUES(@nome, @email, @senha)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int resultado = cmd.ExecuteNonQuery();

                    conn.Close();

                    return resultado > 0;
                }
            }
        }
    }
}
