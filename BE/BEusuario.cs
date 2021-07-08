using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEusuario
    {

        public BEusuario()
        {
        }

        public BEusuario(int iD, string nombre, string apellido, string correo, string contraseña, string estado, int id_cargo)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contraseña = contraseña;
            Estado = estado;
            Id_cargo = id_cargo;
        }

        public BEusuario(string nombre, string apellido, string correo, string contraseña, string estado, int id_cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contraseña = contraseña;
            Estado = estado;
            Id_cargo = id_cargo;
        }

        public BEusuario(string nombre, string apellido, string correo, string contraseña, int id_cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contraseña = contraseña;
            Id_cargo = id_cargo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public int Id_cargo { get; set; }
    }
}
