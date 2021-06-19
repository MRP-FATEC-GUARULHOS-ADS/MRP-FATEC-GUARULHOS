using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MRP_SacoCarvao
{
    class FornecedorComponenteDAO
    {
        public Boolean Insert(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO FORNECEDORCOMPONENTE " +
                    "VALUES( @fornecedor, @componente, @quantidade, @preco ) ; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@fornecedor", fornComp.fornecedor.idFornecedor);
                cmd.Parameters.AddWithValue("@componente", fornComp.componente.idComponente);
                cmd.Parameters.AddWithValue("@quantidade", fornComp.componente.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@preco", fornComp.preco);
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

        public Boolean Update(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE FORNECEDORCOMPONENTE " +
                    "SET qtdeAtualEstoque = @quantidade, preco = @preco " +
                    "WHERE idFornecedor = @fornecedor AND idComponente = @componente ; ";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@fornecedor", fornComp.fornecedor.idFornecedor);
                cmd.Parameters.AddWithValue("@componente", fornComp.componente.idComponente);
                cmd.Parameters.AddWithValue("@quantidade", fornComp.componente.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@preco", fornComp.preco);
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

        public Boolean Delete(FornecedorComponente fornComp)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "DELETE from FORNECEDORCOMPONENTE " +
                    "WHERE idFornecedor = @fornecedor AND idComponente = @componente ; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@fornecedor", fornComp.fornecedor.idFornecedor);
                cmd.Parameters.AddWithValue("@componente", fornComp.componente.idComponente);
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

        public List<FornecedorComponente> GetFornecedorComponentes(Fornecedor forn)
        {
            List<FornecedorComponente> listaFornComps = new List<FornecedorComponente>();
            FornecedorComponente objFornComp;

            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDORCOMPONENTE " +
                    "WHERE idFornecedor = @fornecedor ; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@fornecedor", forn.idFornecedor);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                ComponenteDAO compDAO = new ComponenteDAO();

                while (reader.Read())
                {
                    objFornComp = new FornecedorComponente();
                    objFornComp.fornecedor = forn;
                    objFornComp.componente = compDAO.Get( Convert.ToInt32(reader["idComponente"]) );
                    objFornComp.quantidade = objFornComp.componente.qtdeAtualEstoque;
                    objFornComp.preco = Convert.ToDouble(reader["preco"]);

                    listaFornComps.Add(objFornComp);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaFornComps;
        }

        public FornecedorComponente Get(FornecedorComponente fornComp)
        {
            FornecedorComponente objFornComp = new FornecedorComponente();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "SELECT * FROM FORNECEDORCOMPONENTE " +
                    "WHERE idFornecedor = @fornecedor AND idComponente = @componente ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);

                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@fornecedor", fornComp.fornecedor.idFornecedor);
                cmd.Parameters.AddWithValue("@componente", fornComp.componente.idComponente);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                ComponenteDAO compDAO = new ComponenteDAO();

                objFornComp = new FornecedorComponente();
                objFornComp.componente = compDAO.Get( Convert.ToInt32(reader["idFornecedor"]) );
                objFornComp.preco = Convert.ToDouble(reader["preco"]);

            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return objFornComp;
        }

    }
}
