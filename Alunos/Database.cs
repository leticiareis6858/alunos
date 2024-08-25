using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
                    nome_aluno varchar(100) NOT NULL UNIQUE,
                    email_aluno varchar(45) NOT NULL UNIQUE,
                    whatsapp_aluno varchar(20) DEFAULT NULL UNIQUE,
                    senha_aluno varchar(50) NOT NULL,
                    endereco_aluno varchar(100) DEFAULT NULL,
                    cidade_aluno varchar(100) NOT NULL,
                    data_nasc_aluno varchar(10) DEFAULT NULL,
                    status_matricula_aluno ENUM('ativa', 'inativa') DEFAULT 'ativa', 
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
            using (MySqlConnection conn = GetConnection())
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
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO tb_usuario(nome_usuario, email_usuario, senha_usuario) VALUES(@nome, @email, @senha)";

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

                String query = "INSERT INTO tb_aluno (nome_aluno, email_aluno, senha_aluno, whatsapp_aluno, data_nasc_aluno, cidade_aluno, endereco_aluno) VALUES (@nome, @email, @senha, @telefone, @data_nascimento, @cidade, @endereco)";
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

        public void AtualizarNomeAluno(String nome, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET nome_aluno = @nome WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarEmailAluno(String email, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET email_aluno = @email WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarSenhaAluno(String senha, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET senha_aluno = @senha WHERE matricula_aluno = @id ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarTelefoneAluno(String telefone, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET whatsapp_aluno = @telefone WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarCidadeAluno(String cidade, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET cidade_aluno = @cidade WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarEnderecoAluno(String endereco, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET endereco_aluno = @endereco WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarDataNascAluno(String dataNasc, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET data_nasc_aluno = @data_nasc WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void AtualizarAluno(String nome, String email, String senha, String telefone, String cidade, String endereco, String dataNasc, String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tb_aluno SET nome_aluno = @nome, email_aluno = @email, senha_aluno = @senha, whatsapp_aluno = @telefone, cidade_aluno = @cidade, endereco_aluno = @endereco, data_nasc_aluno = @data_nasc WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                cmd.Parameters.AddWithValue("@id", id);

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

        public bool ExcluirAluno(String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM tb_aluno WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int resultado = cmd.ExecuteNonQuery();

                conn.Close();

                return resultado > 0;
            }
        }


        public string BuscarNomeAluno(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT nome_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarEmailAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT email_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarSenhaAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT senha_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarWhatsappAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT whatsapp_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarCidadeAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT cidade_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarEnderecoAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT endereco_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public String BuscarDataNascAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT data_nasc_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarStatusMatriculaAlunoPorNome(string nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT status_matricula_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarNomeAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT nome_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarEmailAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT email_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarSenhaAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT senha_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarWhatsappAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT whatsapp_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarCidadeAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT cidade_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarEnderecoAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT endereco_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public String BuscarDataNascAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT data_nasc_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public string BuscarStatusMatriculaAlunoPorMatricula(string matricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT status_matricula_aluno FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public String BuscarIdAlunoPorNome(String nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT matricula_aluno FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }
        }

        public DataTable BuscarAlunoPorId(String id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE matricula_aluno = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorNome(String nome)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE nome_aluno LIKE @nome_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome_aluno", "%" + nome + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorEmail(String email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE email_aluno LIKE @email_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email_aluno", "%" + email + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorCidade(String cidade)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE cidade_aluno LIKE @cidade_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade_aluno", "%" + cidade + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorStatusMatricula(String statusMatricula)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE status_matricula_aluno = @status_matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status_matricula_aluno", statusMatricula);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorDataNasc(String dataNasc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE data_nasc_aluno LIKE @data_nasc_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@data_nasc_aluno", "%" + dataNasc + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorEndereco(String endereco)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE endereco_aluno LIKE @endereco_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@endereco_aluno", "%" + endereco + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorWhatsapp(String whatsapp)
        {
            using( MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE whatsapp_aluno LIKE @whatsapp_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@whatsapp_aluno", "%" + whatsapp + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAlunoPorMatricula(String matricula)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tb_aluno WHERE matricula_aluno = @matricula_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricula_aluno", matricula);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public DataTable BuscarAluno(String nome, String matricula, String email, String whatsapp, String endereco, String statusMatricula, String cidade, String dataNasc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                String query= "SELECT * FROM tb_aluno WHERE nome_aluno LIKE @nome AND matricula_aluno LIKE @matricula AND email_aluno LIKE @email AND whatsapp_aluno LIKE @whatsapp AND endereco_aluno LIKE @endereco AND status_matricula_aluno LIKE @statusMatricula AND cidade_aluno LIKE @cidade AND data_nasc_aluno LIKE @dataNasc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
                cmd.Parameters.AddWithValue("@email", "%" + email + "%");
                cmd.Parameters.AddWithValue("@whatsapp", "%" + whatsapp + "%");
                cmd.Parameters.AddWithValue("@endereco", "%" + endereco + "%");
                cmd.Parameters.AddWithValue("@statusMatricula", "%" + statusMatricula + "%");
                cmd.Parameters.AddWithValue("@cidade", "%" + cidade + "%");
                cmd.Parameters.AddWithValue("@dataNasc", "%" + dataNasc + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                return dt;
            }
        }

        public String BuscarNomeUsuarioPorEmail(String email)
        {
            using(MySqlConnection conn=GetConnection())
            {
                conn.Open();
                string query = "SELECT nome_usuario FROM tb_usuario WHERE email_usuario = @email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                object result = cmd.ExecuteScalar();

                conn.Close();

                return result.ToString(); ;

            }
        }

        public List<string> BuscarCidadesCadastradas()
        {
            List<string> cidades = new List<string>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT DISTINCT cidade_aluno FROM tb_aluno";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cidades.Add(reader.GetString("cidade_aluno"));
                    }
                }

                conn.Close();
            }

            return cidades;
        }
    } 
}