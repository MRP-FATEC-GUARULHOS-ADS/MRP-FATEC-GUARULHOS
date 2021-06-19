using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SacoCarvao
{
    class FornecedorDAO
    {
        public Boolean Insert(Fornecedor forn)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO FORNECEDOR ( " +
                    "nomeFornecedor, tipoLogradouro, logradouro, numero, complemento, cep, bairro, cidade, uf, telefone, celular, email, urlSite " +
                    ") VALUES( @nome, @tipo, @logradouro, @numero, @complemento, @cep, @bairro, @cidade, @uf, @telefone, @celular, @email, @urlSite ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@nome", forn.nomeFornecedor);
                cmd.Parameters.AddWithValue("@tipo", forn.tipoLogradouro);
                cmd.Parameters.AddWithValue("@logradouro", forn.logradouro);
                cmd.Parameters.AddWithValue("@numero", forn.numero);
                cmd.Parameters.AddWithValue("@complemento", forn.complemento);
                cmd.Parameters.AddWithValue("@cep", forn.cep);
                cmd.Parameters.AddWithValue("@bairro", forn.bairro);
                cmd.Parameters.AddWithValue("@cidade", forn.cidade);
                cmd.Parameters.AddWithValue("@uf", forn.uf);
                cmd.Parameters.AddWithValue("@telefone", forn.telefone);
                cmd.Parameters.AddWithValue("@celular", forn.celular);
                cmd.Parameters.AddWithValue("@email", forn.email);
                cmd.Parameters.AddWithValue("@urlSite", forn.urlSite);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public Boolean Update(Fornecedor forn)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE FORNECEDOR " +
                    "SET nomeFornecedor = @nome, tipoLogradouro = @tipo, logradouro = @logradouro, " +
                    "numero = @numero, complemento = @complemento, cep = @cep, " +
                    "bairro = @bairro, cidade = @cidade, uf = @uf, " +
                    "telefone = @telefone, celular = @celular, email = @email, urlSite = @urlSite " +
                    "WHERE idFornecedor = @id; ";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", forn.idFornecedor);
                cmd.Parameters.AddWithValue("@nome", forn.nomeFornecedor);
                cmd.Parameters.AddWithValue("@tipo", forn.tipoLogradouro);
                cmd.Parameters.AddWithValue("@logradouro", forn.logradouro);
                cmd.Parameters.AddWithValue("@numero", forn.numero);
                cmd.Parameters.AddWithValue("@complemento", forn.complemento);
                cmd.Parameters.AddWithValue("@cep", forn.cep);
                cmd.Parameters.AddWithValue("@bairro", forn.bairro);
                cmd.Parameters.AddWithValue("@cidade", forn.cidade);
                cmd.Parameters.AddWithValue("@uf", forn.uf);
                cmd.Parameters.AddWithValue("@telefone", forn.telefone);
                cmd.Parameters.AddWithValue("@celular", forn.celular);
                cmd.Parameters.AddWithValue("@email", forn.email);
                cmd.Parameters.AddWithValue("@urlSite", forn.urlSite);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public Boolean Delete(int id)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE from FORNECEDOR " +
                    "WHERE idFornecedor = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public List<Fornecedor> GetFornecedores()
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT f.* FROM FORNECEDOR f";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objFornecedor = new Fornecedor();
                    objFornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    objFornecedor.nomeFornecedor = (string)reader["nomeFornecedor"];
                    objFornecedor.tipoLogradouro = (reader["tipoLogradouro"] != DBNull.Value ? (string)(reader["tipoLogradouro"]) : "");
                    objFornecedor.logradouro = (string)reader["logradouro"];
                    objFornecedor.numero = (string)reader["numero"];
                    objFornecedor.complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : "");
                    objFornecedor.cep = (string)reader["cep"];
                    objFornecedor.bairro = (string)reader["bairro"];
                    objFornecedor.cidade = (string)reader["cidade"];
                    objFornecedor.uf = (string)reader["uf"];
                    objFornecedor.telefone = (string)reader["telefone"];
                    objFornecedor.celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : "");
                    objFornecedor.email = (string)reader["email"];
                    objFornecedor.urlSite = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "");

                    listaFornecedores.Add(objFornecedor);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaFornecedores;
        }

        public List<Fornecedor> PesquisaFornecedores(string pesquisa)
        {
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            Fornecedor objFornecedor;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDOR " +
                    "WHERE idFornecedor LIKE @pesquisa " +
                    "OR nomeFornecedor LIKE @pesquisa " +
                    "OR logradouro LIKE @pesquisa " +
                    "OR cep LIKE @pesquisa " +
                    "OR bairro LIKE @pesquisa " +
                    "OR cidade LIKE @pesquisa " +
                    "OR uf LIKE @pesquisa " +
                    "OR telefone LIKE @pesquisa " +
                    "OR celular LIKE @pesquisa " +
                    "OR email LIKE @pesquisa ;";

                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                cmd.Prepare();
                Console.WriteLine(query);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objFornecedor = new Fornecedor();
                    objFornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    objFornecedor.nomeFornecedor = (string)reader["nomeFornecedor"];
                    objFornecedor.tipoLogradouro = (reader["tipoLogradouro"] != DBNull.Value ? (string)(reader["tipoLogradouro"]) : "");
                    objFornecedor.logradouro = (string)reader["logradouro"];
                    objFornecedor.numero = (string)reader["numero"];
                    objFornecedor.complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : "");
                    objFornecedor.cep = (string)reader["cep"];
                    objFornecedor.bairro = (string)reader["bairro"];
                    objFornecedor.cidade = (string)reader["cidade"];
                    objFornecedor.uf = (string)reader["uf"];
                    objFornecedor.telefone = (string)reader["telefone"];
                    objFornecedor.celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : "");
                    objFornecedor.email = (string)reader["email"];
                    objFornecedor.urlSite = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "");

                    listaFornecedores.Add(objFornecedor);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaFornecedores;
        }

        public Fornecedor Get(int id)
        {
            Fornecedor objFornecedor = new Fornecedor();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT f.* FROM FORNECEDOR f WHERE idFornecedor = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);

                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objFornecedor = new Fornecedor();
                objFornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                objFornecedor.nomeFornecedor = (string)reader["nomeFornecedor"];
                objFornecedor.tipoLogradouro = (reader["tipoLogradouro"] != DBNull.Value ? (string)(reader["tipoLogradouro"]) : "");
                objFornecedor.logradouro = (string)reader["logradouro"];
                objFornecedor.numero = (string)reader["numero"];
                objFornecedor.complemento = (reader["complemento"] != DBNull.Value ? (string)(reader["complemento"]) : "");
                objFornecedor.cep = (string)reader["cep"];
                objFornecedor.bairro = (string)reader["bairro"];
                objFornecedor.cidade = (string)reader["cidade"];
                objFornecedor.uf = (string)reader["uf"];
                objFornecedor.telefone = (string)reader["telefone"];
                objFornecedor.celular = (reader["celular"] != DBNull.Value ? (string)(reader["celular"]) : "");
                objFornecedor.email = (string)reader["email"];
                objFornecedor.urlSite = (reader["urlSite"] != DBNull.Value ? (string)(reader["urlSite"]) : "");

            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return objFornecedor;
        }

    }
}
