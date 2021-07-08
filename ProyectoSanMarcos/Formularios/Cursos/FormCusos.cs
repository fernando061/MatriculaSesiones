using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;

namespace ProyectoSanMarcos.Formularios.Cursos
{
    public partial class FormCusos : Form
    {
        private int id;
        public FormCusos(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private BLcursos bLcursos = new BLcursos();
        private BEcursos bEcursos = new BEcursos();
        int h = 0;
        private void FormCusos_Load(object sender, EventArgs e)
        {
           
            cargar();
            
        }

        public void cargar()
        {
            if (id == 3)
            {
                DataTable dt = new DataTable();
                bLcursos.buscarCursoText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                dgvMatricula.Refresh();
                dgvMatricula.ReadOnly = true;
                BLprofesores bLprofesores = new BLprofesores();
                DataTable dt1 = new DataTable();
                bLprofesores.ProfesoresCmb(ref dt1);
                cmbProfesores.DataSource = dt1;
                cmbProfesores.ValueMember = "id_profesor";
                cmbProfesores.DisplayMember = "apellido";
                txtNombre.Enabled = false;
                txtN.Enabled = false;
                cmbProfesores.SelectedIndex = 0;
                btnCancelar.Visible = false;
                btnEditar.Enabled = false;
                button3.Enabled = false;
                btnGuardar.Enabled = false;
                btnAdmin.Visible = false;
                cmbProfesores.Enabled = false;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
            }
            else if (id == 2)
            {
                DataTable dt = new DataTable();
                bLcursos.buscarCursoText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                dgvMatricula.Refresh();
                dgvMatricula.ReadOnly = true;
                BLprofesores bLprofesores = new BLprofesores();
                DataTable dt1 = new DataTable();
                bLprofesores.ProfesoresCmb(ref dt1);
                cmbProfesores.DataSource = dt1;
                cmbProfesores.ValueMember = "id_profesor";
                cmbProfesores.DisplayMember = "apellido";
                txtNombre.Text = null;
                txtN.Text = null;
                cmbProfesores.SelectedIndex = 0;
                btnCancelar.Visible = false;
                btnEditar.Enabled = false;
                button3.Enabled = false;
                btnGuardar.Enabled = true;
                btnAdmin.Visible = false;
                cmbProfesores.Enabled = true;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                txtId.Text = null;
                Estado.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                
            }
            else if (id == 1)
            {

                DataTable dt = new DataTable();
                bLcursos.buscarCursoText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                dgvMatricula.Refresh();
                dgvMatricula.ReadOnly = true;
                BLprofesores bLprofesores = new BLprofesores();
                DataTable dt1 = new DataTable();
                bLprofesores.ProfesoresCmb(ref dt1);
                cmbProfesores.DataSource = dt1;
                cmbProfesores.ValueMember = "id_profesor";
                cmbProfesores.DisplayMember = "apellido";
                txtNombre.Text = null;
                txtN.Text = null;
                cmbProfesores.SelectedIndex = 0;
                btnCancelar.Visible = false;
                btnEditar.Enabled = false;
                button3.Enabled = false;
                btnGuardar.Enabled = true;
                btnAdmin.Enabled = false;
                cmbProfesores.Enabled = true;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                txtId.Text = null;
                cmbEstado.SelectedIndex = 0;
                cmbEstado.Enabled = false;
                Estado.Enabled = false;
            }

            

            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals("") | cmbProfesores.SelectedIndex == 0)
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string NOMBRE = txtNombre.Text;
                int id_profesor = Convert.ToInt32(cmbProfesores.SelectedValue);
                NOMBRE +="-"+txtN.Text;
                bEcursos = new BEcursos(NOMBRE, id_profesor);
                bLcursos.insertarCurso(bEcursos);
                cargar();
            }

        }

        private void dgvMatricula_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (id == 2)
            {
                btnCancelar.Visible = true;
                btnEditar.Enabled = true;
                button3.Enabled = true;
                btnGuardar.Enabled = false;
                BLprofesores bLprofesores = new BLprofesores();
                int ids = Convert.ToInt32(dgvMatricula.CurrentRow.Index);
                txtId.Text = dgvMatricula.Rows[ids].Cells[0].Value.ToString();
                string operacion = dgvMatricula.Rows[ids].Cells[1].Value.ToString();
                string[] trozo = operacion.Split('-');
                txtNombre.Text = trozo[0];
                txtN.Text = trozo[1];
                cmbEstado.Text = dgvMatricula.Rows[ids].Cells[2].Value.ToString();
                string cod = dgvMatricula.Rows[ids].Cells[3].Value.ToString();
                cmbProfesores.SelectedValue = bLprofesores.CodProfesor(cod).ToString();
                
            }
            else if (id == 1)
            {
                btnAdmin.Enabled = true;
                btnCancelar.Visible = true;
                btnEditar.Enabled = true;
                button3.Enabled = true;
                btnGuardar.Enabled = false;
                BLprofesores bLprofesores = new BLprofesores();
                int ids = Convert.ToInt32(dgvMatricula.CurrentRow.Index);
                txtId.Text = dgvMatricula.Rows[ids].Cells[0].Value.ToString();
                string operacion = dgvMatricula.Rows[ids].Cells[1].Value.ToString();
                string[] trozo = operacion.Split('-');
                txtNombre.Text = trozo[0];
                txtN.Text = trozo[1];
                cmbEstado.Text = dgvMatricula.Rows[ids].Cells[2].Value.ToString();
                string cod = dgvMatricula.Rows[ids].Cells[3].Value.ToString();
                cmbProfesores.SelectedValue = bLprofesores.CodProfesor(cod).ToString();
                cmbEstado.Enabled = true;
                cmbEstado.Visible = true;
                Estado.Visible = true;
                Estado.Enabled = true;
            }
            
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)

        {
            if (txtNombre.Text.Equals("") | cmbProfesores.SelectedIndex == 0)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                if (MessageBox.Show("¿Estas Seguro de editar?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string curso="";

                    string cod = txtId.Text;
                    string estado = cmbEstado.Text;
                    int profesor = Convert.ToInt32(cmbProfesores.SelectedValue);
                    curso = txtNombre.Text + "-" + txtN.Text;
                    bEcursos = new BEcursos(cod, curso,estado,profesor);
                    bLcursos.UpdateCurso(bEcursos);
                    cargar();
                }
            }

            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                
                string cod = txtId.Text;
                bLcursos.deletCurso(cod);
                cargar();
            }

            cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvMatricula_SizeChanged(object sender, EventArgs e)
        {
            
            
            btnEditar.Location = new Point(28, dgvMatricula.Size.Height + 220);
            button3.Location = new Point(125, dgvMatricula.Size.Height + 220);
            btnCancelar.Location = new Point(222, dgvMatricula.Size.Height + 220);
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            bLcursos.EliminarCurso(txtId.Text);
            cargar();
        }
    }
}
