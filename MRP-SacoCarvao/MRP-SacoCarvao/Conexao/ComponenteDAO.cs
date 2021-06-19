using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SacoCarvao
{
    class ComponenteDAO
    {
        public Boolean Insert(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO COMPONENTE ( " +
                    "tipoComponente, modeloComponente, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque, especificacao" +
                    ") VALUES( @tipo, @modelo, @qntmin, @qntmax, @qntatual, @espec ); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipoComponente);
                cmd.Parameters.AddWithValue("@modelo", comp.modeloComponente);
                cmd.Parameters.AddWithValue("@qntmin", comp.qtdeMinEstoque);
                cmd.Parameters.AddWithValue("@qntmax", comp.qtdeMaxEstoque);
                cmd.Parameters.AddWithValue("@qntatual", comp.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@espec", comp.especificacao);
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

        public Boolean Update(Componente comp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE componente " +
                    "SET tipoComponente = @tipo, modeloComponente = @modelo, qtdeMinEstoque = @qntmin, " +
                    "qtdeMaxEstoque = @qntmax, qtdeAtualEstoque = @qntatual, especificacao = @espec " +
                    "WHERE idComponente = @id; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@tipo", comp.tipoComponente);
                cmd.Parameters.AddWithValue("@modelo", comp.modeloComponente);
                cmd.Parameters.AddWithValue("@qntmin", comp.qtdeMinEstoque);
                cmd.Parameters.AddWithValue("@qntmax", comp.qtdeMaxEstoque);
                cmd.Parameters.AddWithValue("@qntatual", comp.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@espec", comp.especificacao);
                cmd.Parameters.AddWithValue("@id", comp.idComponente);
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
                string query = "DELETE from componente " +
                    "WHERE idComponente = @id; ";
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

        public List<Componente> GetComponentes()
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objComponente = new Componente();
                    objComponente.idComponente = Convert.ToInt32(reader["idComponente"]);
                    objComponente.tipoComponente = (string)reader["tipoComponente"];
                    objComponente.modeloComponente = (string)reader["modeloComponente"];
                    objComponente.qtdeMinEstoque = Convert.ToInt32(reader["qtdeMinEstoque"]);
                    objComponente.qtdeMaxEstoque = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                    objComponente.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                    objComponente.especificacao = (reader["especificacao"] != DBNull.Value ? (string)(reader["especificacao"]) : "");

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public List<Componente> PesquisaComponentes(string pesquisa)
        {
            List<Componente> listaComponentes = new List<Componente>();
            Componente objComponente;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM componente " +
                    "WHERE idComponente LIKE @pesquisa " +
                    "OR tipoComponente LIKE @pesquisa " +
                    "OR modeloComponente LIKE @pesquisa " +
                    "OR especificacao LIKE @pesquisa;";
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
                    objComponente = new Componente();
                    objComponente.idComponente = Convert.ToInt32(reader["idComponente"]);
                    objComponente.tipoComponente = (string)reader["tipoComponente"];
                    objComponente.modeloComponente = (string)reader["modeloComponente"];
                    objComponente.qtdeMinEstoque = Convert.ToInt32(reader["qtdeMinEstoque"]);
                    objComponente.qtdeMaxEstoque = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                    objComponente.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                    objComponente.especificacao = (reader["especificacao"] != DBNull.Value ? (string)(reader["especificacao"]) : "");

                    listaComponentes.Add(objComponente);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaComponentes;
        }

        public Componente Get(int id)
        {
            Componente objComponente = new Componente();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT c.* FROM componente c WHERE idComponente = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                objComponente.idComponente = Convert.ToInt32(reader["idComponente"]);
                objComponente.tipoComponente = (string)reader["tipoComponente"];
                objComponente.modeloComponente = (string)reader["modeloComponente"];
                objComponente.qtdeMinEstoque = Convert.ToInt32(reader["qtdeMinEstoque"]);
                objComponente.qtdeMaxEstoque = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                objComponente.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                objComponente.especificacao = (reader["especificacao"] != DBNull.Value ? (string)(reader["especificacao"]) : "");

            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return objComponente;
        }

    }
}
