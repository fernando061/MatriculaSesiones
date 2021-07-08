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
    public partial class FormReportAlumno : Form
    {
        public FormReportAlumno()
        {
            InitializeComponent();
        }
        public string DNI { get; set; }
        private void FormReportAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSreportAlumno.ReportAlumno' Puede moverla o quitarla según sea necesario.
            this.ReportAlumnoTableAdapter.Fill(this.DSreportAlumno.ReportAlumno,DNI);
            this.reportViewer1.RefreshReport();
        }
    }
}
