using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    public partial class FormProfesor : Form
    {
        public FormProfesor()
        {
            InitializeComponent();
        }
        public string DNI { get; set; }
        private void FormProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSProfesor.ReporteProfesor' Puede moverla o quitarla según sea necesario.
            this.ReporteProfesorTableAdapter.Fill(this.DSProfesor.ReporteProfesor,DNI);

            this.reportViewer1.RefreshReport();
        }
    }
}
