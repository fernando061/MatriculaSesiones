using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEmatricula
    {
        public BEmatricula()
        {
        }

        public BEmatricula(string id_matricula, string nombre, string apellido, string numDoc, string correo, string telefono, DateTime fecha_deposito, decimal monto, string banco_deposito, string numero_operacion, int id_curso, string estado)
        {
            Id_matricula = id_matricula;
            Nombre = nombre;
            Apellido = apellido;
            NumDoc = numDoc;
            Correo = correo;
            Telefono = telefono;
            Fecha_deposito = fecha_deposito;
            Monto = monto;
            Banco_deposito = banco_deposito;
            Numero_operacion = numero_operacion;
            Id_curso = id_curso;
            Estado = estado;

        }

        public BEmatricula(string nombre, string apellido, string numDoc, string correo, string telefono, DateTime fecha_deposito, decimal monto, string banco_deposito, string numero_operacion, int id_curso, byte[] file,string extencion)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumDoc = numDoc;
            Correo = correo;
            Telefono = telefono;
            Fecha_deposito = fecha_deposito;
            Monto = monto;
            Banco_deposito = banco_deposito;
            Numero_operacion = numero_operacion;
            Id_curso = id_curso;
            File = file;
            Extencion = extencion;
        }

        public string Id_matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumDoc { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_deposito { get; set; }
        public Decimal Monto { get; set; }
        public string Banco_deposito { get; set; }
        public string Numero_operacion { get; set; }
        public int Id_curso { get; set; }
        public string Estado { get; set; }
        public byte[] File { get; set; }
        public string Extencion { get; set; }
    }
}
