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

                    conn.Close();

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

        public void cadastrarAluno(String nome, String email, String senha, String telefone, String data_nasc, String cidade, String endereco)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                String query = "INSERT INTO tb_aluno (nome_aluno, email_aluno, senha_aluno, telefone_aluno, data_nasc_aluno, cidade_aluno, endereco_aluno) VALUES (@nome, @email, @senha, @telefone, @data_nascimento, @cidade, @endereco)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nasc);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarEmailAluno(String nome, String email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET email_aluno = @email WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarSenhaAluno(String nome, String senha)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET senha_aluno = @senha WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarTelefoneAluno(String nome, String telefone)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET telefone_aluno = @telefone WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarCidadeAluno(String nome, String cidade)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET cidade_aluno = @cidade WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarEnderecoAluno(String nome, String endereco)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET endereco_aluno = @endereco WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarDataNascAluno(String nome, String dataNasc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET data_nasc_aluno = @data_nasc WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarAluno(String nome, String email, String senha, String telefone, String cidade, String endereco, String dataNasc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET email_aluno = @email, senha_aluno = @senha, telefone_aluno = @telefone, cidade_aluno = @cidade, endereco_aluno = @endereco, data_nasc_aluno = @data_nasc WHERE nome_aluno = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                cmd.Parameters.AddWithValue("@nome", nome);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public DataTable BuscarAlunos()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM tb_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

    }
}
