using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEprofesores
    {
        public BEprofesores()
        {
        }

        public BEprofesores(string id_profesores, string noombre, string apellido, string num_doc, string telefono, string correo, string estado)
        {
            Id_profesores = id_profesores;
            Noombre = noombre;
            Apellido = apellido;
            Num_doc = num_doc;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
        }

        public BEprofesores(string noombre, string apellido, string num_doc, string telefono, string correo, string estado)
        {
            Noombre = noombre;
            Apellido = apellido;
            Num_doc = num_doc;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
        }

        public BEprofesores(string noombre, string apellido, string num_doc, string telefono, string correo)
        {
            Noombre = noombre;
            Apellido = apellido;
            Num_doc = num_doc;
            Telefono = telefono;
            Correo = correo;
        }

        public string Id_profesores { get; set; }
        public string Noombre { get; set; }
        public string Apellido { get; set; }
        public string Num_doc { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }

    }
}
