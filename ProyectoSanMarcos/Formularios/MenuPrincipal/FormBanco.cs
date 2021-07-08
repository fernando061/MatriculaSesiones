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
    public partial class FormBanco : Form
    {
        public FormBanco()
        {
            InitializeComponent();
        }
        public string Banco { get; set; }
        public string Curso { get; set; }
        private void FormBanco_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'DSBanco.bancoReport' Puede moverla o quitarla según sea necesario.
            this.bancoReportTableAdapter.Fill(this.DSBanco.bancoReport,Banco,Curso);

            this.reportViewer1.RefreshReport();
        }
    }
}
