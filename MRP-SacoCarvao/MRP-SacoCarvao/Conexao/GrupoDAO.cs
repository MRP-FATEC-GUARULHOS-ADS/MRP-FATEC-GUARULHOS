using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MRP_SacoCarvao
{
    class GrupoDAO
    {
        public Boolean Insert(Grupo grupo)
        {
            Conexao conexao = new Conexao();
            if (conexao.mErro.Length > 0)
            {
                return false;
            }
            try
            {
                String query = "Insert Into Grupo values (@id, @nome)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }
                cmd.Parameters.AddWithValue("@id", grupo.idGrupo);
                cmd.Parameters.AddWithValue("@nome", grupo.nomeGrupo);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public Boolean Update(Grupo grupo)
        {
            Conexao conexao = new Conexao();
            if (conexao.mErro.Length > 0)
            {
                return false;
            }
            try
            {
                String query = "Update Grupo Set nomeGrupo=@nome Where idGrupo=@id;";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }
                cmd.Parameters.AddWithValue("@nome", grupo.nomeGrupo);
                cmd.Parameters.AddWithValue("@id", grupo.idGrupo);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
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
                String query = "Delete From Grupo Where idGrupo = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return false;
                }
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return false;
            }
            conexao.CloseConexao();
            return true;
        }

        public List<Grupo> GetGrupos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            Grupo grupo;
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "Select * From grupo";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    grupo = new Grupo();
                    grupo.idGrupo = Convert.ToInt32(reader["idGrupo"]);
                    grupo.nomeGrupo = (string)reader["nomeGrupo"];
                    listaGrupos.Add(grupo);
                }
            }
            catch (MySqlException e)
            {
            }
            conexao.CloseConexao();
            return listaGrupos;
        }

        public Grupo Get(int id)
        {
            Grupo grupo = new Grupo();
            Conexao conexao = new Conexao();

            if (conexao.mErro.Length > 0)
            {
                return null;
            }

            try
            {
                MySqlDataReader reader;
                string query = "select * from grupo where idGrupo = (@id)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                if (!conexao.OpenConexao())
                {
                    return null;
                }

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                reader = cmd.ExecuteReader();
                reader.Read();
                grupo.idGrupo = Convert.ToInt32(reader["idGrupo"]);
                grupo.nomeGrupo = (string)reader["nomeGrupo"];
            }
            catch (MySqlException e)
            {
                return null;
            }
            conexao.CloseConexao();
            return grupo;
        }

    }    
}
