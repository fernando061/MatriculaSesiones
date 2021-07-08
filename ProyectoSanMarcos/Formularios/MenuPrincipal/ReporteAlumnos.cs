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
    public partial class ReporteAlumnos : Form
    {
        public ReporteAlumnos()
        {
            InitializeComponent();
        }
        public string Estado { get; set; }
        private void ReporteAlumnos_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'DSAlumnos.ReportAlumnos' Puede moverla o quitarla según sea necesario.
            this.ReportAlumnosTableAdapter.Fill(this.DSAlumnos.ReportAlumnos,Estado);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
