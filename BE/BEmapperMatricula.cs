using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEmapperMatricula
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_deposito { get; set; }
        public Decimal Monto { get; set; }
        public string Banco_deposito { get; set; }
        public string Numero_operacion { get; set; }
        public string Estado { get; set; }
        public int Id_curso { get; set; }
    }
}
