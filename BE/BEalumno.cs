using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEalumno
    {
        public BEalumno()
        {
        }

        public BEalumno(string nombre, string apellido, string numdoc, string telefono, string estado, int idMatricula, int idCurso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Numdoc = numdoc;
            Telefono = telefono;
            Estado = estado;
            IdMatricula = idMatricula;
            IdCurso = idCurso;
        }

        public BEalumno(string nombre, string apellido, string telefono, int idMatricula, int idCurso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            IdMatricula = idMatricula;
            IdCurso = idCurso;
        }

        public BEalumno(string cODALUMNO, string nombre, string apellido, string numdoc, string telefono, string estado, int idMatricula, int idCurso)
        {
            CODALUMNO = cODALUMNO;
            Nombre = nombre;
            Apellido = apellido;
            Numdoc = numdoc;
            Telefono = telefono;
            Estado = estado;
            IdMatricula = idMatricula;
            IdCurso = idCurso;
        }

        public BEalumno(string nombre, string apellido, string numdoc, string telefono, int idMatricula, int idCurso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Numdoc = numdoc;
            Telefono = telefono;
            IdMatricula = idMatricula;
            IdCurso = idCurso;
        }

        public string CODALUMNO { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Numdoc { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public int IdMatricula { get; set; }
        public int IdCurso { get; set; }
    }
}
