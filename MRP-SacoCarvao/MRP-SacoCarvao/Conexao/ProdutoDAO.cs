using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MRP_SacoCarvao
{
    class ProdutoDAO
    {
        public Boolean Insert(Produto produto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "INSERT INTO PRODUTO ( " +
                    "nomeProduto, descrProduto, qtdeMinEstoque, qtdeMaxEstoque, qtdeAtualEstoque," +
                    "altura, comprimento, largura, peso, especificacao, idGrupo" +
                    ") VALUES(@nome, @descr, @qtdeMin, @qtdeMax, @qtdeAtual, @alt, @comprim, @larg, @pes, @espec, @idGrup); ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }


                cmd.Parameters.AddWithValue("@nome", produto.nomeProduto);
                cmd.Parameters.AddWithValue("@descr", produto.descrProduto);
                cmd.Parameters.AddWithValue("@qtdeMin", produto.qtdeMinEstoque);
                cmd.Parameters.AddWithValue("@qtdeMax", produto.qtdeMaxEstoque);
                cmd.Parameters.AddWithValue("@qtdeAtual", produto.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@alt", produto.altura);
                cmd.Parameters.AddWithValue("@comprim", produto.comprimento);
                cmd.Parameters.AddWithValue("@larg", produto.largura);
                cmd.Parameters.AddWithValue("@pes", produto.peso);
                cmd.Parameters.AddWithValue("@espec", produto.especificacao);
                cmd.Parameters.AddWithValue("@idGrup", produto.grupo.GetidGrupo());
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

        public Boolean Update(Produto produto)
        {
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return false;
            }

            try
            {
                MySqlDataReader reader;
                string query = "UPDATE produto " +
                    "SET nomeProduto = @nome, descrProduto = @descr, qtdeMinEstoque = @qtdeMin, " +
                    "qtdeMaxEstoque = @qtdeMax, qtdeAtualEstoque = @qtdeAtual, altura = @alt, " +
                    "comprimento = @comprim, largura = @larg, peso = @pes, especificacao = @espec, idGrupo = @idGrup " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", produto.idProduto);
                cmd.Parameters.AddWithValue("@nome", produto.nomeProduto);
                cmd.Parameters.AddWithValue("@descr", produto.descrProduto);
                cmd.Parameters.AddWithValue("@qtdeMin", produto.qtdeMinEstoque);
                cmd.Parameters.AddWithValue("@qtdeMax", produto.qtdeMaxEstoque);
                cmd.Parameters.AddWithValue("@qtdeAtual", produto.qtdeAtualEstoque);
                cmd.Parameters.AddWithValue("@alt", produto.altura);
                cmd.Parameters.AddWithValue("@comprim", produto.comprimento);
                cmd.Parameters.AddWithValue("@larg", produto.largura);
                cmd.Parameters.AddWithValue("@pes", produto.peso);
                cmd.Parameters.AddWithValue("@espec", produto.especificacao);
                cmd.Parameters.AddWithValue("@idGrup", produto.grupo.GetidGrupo());
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
                string query = "DELETE FROM produto " +
                    "WHERE idProduto = @idProd; ";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }

                cmd.Parameters.AddWithValue("@idProd", id);
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


        public void AtualizarLista(DataGridView e)
        {
            ProdutoDAO objCompDAO = new ProdutoDAO();
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos = objCompDAO.GetProdutos();

            var lista = new BindingList<Produto>(listaProdutos);
            e.DataSource = lista;
        }

        public List<Produto> GetProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto produto;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select p.*, g.nomeGrupo From produto p Inner Join grupo g On (p.idGrupo = g.idGrupo)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produto = new Produto();
                    produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                    produto.nomeProduto = (string)reader["nomeProduto"];
                    produto.descrProduto = (string)reader["descrProduto"];
                    produto.qtdeMinEstoque = Convert.ToInt32(reader["qtdeMinEstoque"]);
                    produto.qtdeMaxEstoque = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                    produto.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                    produto.altura = (reader["altura"] != DBNull.Value ? Convert.ToSingle(reader["altura"]) : 0);
                    produto.comprimento = (reader["comprimento"] != DBNull.Value ? Convert.ToSingle(reader["comprimento"]) : 0);
                    produto.peso = (reader["peso"] != DBNull.Value ? Convert.ToSingle(reader["peso"]) : 0);
                    produto.especificacao = (reader["especificacao"] != DBNull.Value ? (string)(reader["especificacao"]) : "");
                    produto.grupo = new Grupo (Convert.ToInt32(reader["idGrupo"]), (string)reader["nomeGrupo"]);

                    listaProdutos.Add(produto);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaProdutos;
        }

        public Produto Get(int id)
        {
            Produto produto = new Produto();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select p.*, g.nomeGrupo From produto p Inner Join grupo g On (p.idGrupo = g.idGrupo) where idProduto = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();

                produto = new Produto();
                produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                produto.nomeProduto = (string)reader["nomeProduto"];
                produto.descrProduto = (string)reader["descrProduto"];
                produto.qtdeMinEstoque = Convert.ToInt32(reader["qtdeMinEstoque"]);
                produto.qtdeMaxEstoque = Convert.ToInt32(reader["qtdeMaxEstoque"]);
                produto.qtdeAtualEstoque = Convert.ToInt32(reader["qtdeAtualEstoque"]);
                produto.altura = (reader["altura"] != DBNull.Value ? Convert.ToSingle(reader["altura"]) : 0);
                produto.comprimento = (reader["comprimento"] != DBNull.Value ? Convert.ToSingle(reader["comprimento"]) : 0);
                produto.peso = (reader["peso"] != DBNull.Value ? Convert.ToSingle(reader["peso"]) : 0);
                produto.especificacao = (reader["especificacao"] != DBNull.Value ? (string)(reader["especificacao"]) : "");
                produto.grupo = new Grupo(Convert.ToInt32(reader["idGrupo"]), (string)reader["nomeGrupo"]);

            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return produto;
        }

    }    
}
