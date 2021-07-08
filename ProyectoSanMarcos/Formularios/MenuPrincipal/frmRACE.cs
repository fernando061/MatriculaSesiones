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
    public partial class frmRACE : Form
    {
        public frmRACE()
        {
            InitializeComponent();
        }
        public string Estado { get; set; }
        public string Curso { get; set; }
        private void frmRACE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSEstadoCA.NumACursoEstado' Puede moverla o quitarla según sea necesario.
            this.NumACursoEstadoTableAdapter.Fill(this.DSEstadoCA.NumACursoEstado,Curso,Estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
