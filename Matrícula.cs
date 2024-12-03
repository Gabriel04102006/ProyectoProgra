using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra
{
    internal class Matrícula
    {
        private int id;
        private string nombre;
        private int usuarioID;
        private int cursoID;

        public Matrícula(int usuarioID, int cursoID)
        {
            this.usuarioID = usuarioID;
            this.cursoID = cursoID;
        }

        public int UsuarioID { get; internal set; }
        public int CursoID { get; internal set; }
    }

}
