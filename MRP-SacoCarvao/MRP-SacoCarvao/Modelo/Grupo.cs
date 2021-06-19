using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SacoCarvao
{
    class Grupo
    {
        public int idGrupo { get;  set; }
        public string nomeGrupo { get; set; }

        public int GetidGrupo()
        {
            return idGrupo;
        }

        public void GetnomeGrupo(string nomeGrupo)
        {
            this.nomeGrupo = nomeGrupo;
        }
        public Grupo() { }
        public Grupo(int idGrupo, string nomeGrupo)
        {
            this.idGrupo = idGrupo;
            this.nomeGrupo = nomeGrupo;
        }
    }
}
