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
    public partial class FormRProfesores : Form
    {
        public FormRProfesores()
        {
            InitializeComponent();
        }
        public string Estado { get; set; }
        private void FormProfesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSprofesores.ReporteProfesores' Puede moverla o quitarla según sea necesario.
            this.ReporteProfesoresTableAdapter.Fill(this.DSprofesores.ReporteProfesores,Estado);
            // TODO: esta línea de código carga datos en la tabla 'DSprofesores.ReporteProfesores' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
