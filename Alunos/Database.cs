using MySql.Data.MySqlClient;
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
                    email_aluno varchar(45) NOT NULL,
                    whatsapp_aluno varchar(20) DEFAULT NULL,
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
                    email_usuario varchar(100) NOT NULL,
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
    }
}
