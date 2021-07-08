using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;
namespace ProyectoSanMarcos.Formularios.Alumnos
{
    public partial class FormAlumnos : Form
    {
        private int id;
        public FormAlumnos(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private BLalumnos bLalumnos = new BLalumnos();
        private BEalumno bEalumno = new BEalumno();
        
        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        public void Cargar()
        {
            if (id == 3)
            {
                DataTable dt = new DataTable();
                bLalumnos.buscarAlumnoText(ref dt, txtBuscar.Text);
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = dt;
                dgvAlumnos.Refresh();
                dgvAlumnos.ReadOnly = true;
                

            }
            else if(id==1 | id==2)
            {
                DataTable dt = new DataTable();
                bLalumnos.buscarAlumnoText(ref dt, txtBuscar.Text);
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = dt;
                dgvAlumnos.Refresh();
                dgvAlumnos.ReadOnly = true;
            }
            
        }

        



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

       
    }
}
