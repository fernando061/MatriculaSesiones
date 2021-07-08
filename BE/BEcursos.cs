using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcursos
    {
        public BEcursos()
        {
        }

        public BEcursos(string cODCURSO, string nombre_curso, string estado, int id_Profesor)
        {
            CODCURSO = cODCURSO;
            Nombre_curso = nombre_curso;
            Estado = estado;
            Id_Profesor = id_Profesor;
        }

        public BEcursos(string nombre_curso, int id_Profesor)
        {
            Nombre_curso = nombre_curso;
            Id_Profesor = id_Profesor;
        }

        public string CODCURSO { get; set; }
        public string Nombre_curso { get; set; }
        public string Estado { get; set; }
        public int Id_Profesor { get; set; }
    }
}
