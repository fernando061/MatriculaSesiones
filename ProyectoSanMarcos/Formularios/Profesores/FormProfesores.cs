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
namespace ProyectoSanMarcos.Formularios.Profesores
{
    public partial class FormProfesores : Form
    {
        private int id;
        public FormProfesores(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private BLprofesores bLprofesores = new BLprofesores();
        private BEprofesores bEprofesores = new BEprofesores();
        private void FormProfesores_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text.Equals("") | txtNombre.Text.Equals("") | txtNumdoc.Text.Equals("") | txtTelefono.Equals(""))
            {
                MessageBox.Show("Llene los campos por favor", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            else
            {
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Num_doc = txtNumdoc.Text;
                string Telefono = txtTelefono.Text;
                string Correo = txtCorreo.Text;
                bEprofesores = new BEprofesores(Nombre, Apellido, Num_doc, Telefono,Correo);
                bLprofesores.insertarProfesor(bEprofesores);
                clear();
            }
            
        }

        public void clear()
        {
            if (id == 3)
            {
                DataTable dt = new DataTable();
                BLprofesores bLprofesores = new BLprofesores();
                bLprofesores.buscarProfesoresText(ref dt, txtBuscar.Text);
                dgvProfesores.DataSource = null;
                dgvProfesores.DataSource = dt;
                dgvProfesores.Refresh();
                dgvProfesores.ReadOnly = true;
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtNumdoc.Enabled = false;
                txtTelefono.Enabled = false;               
                btnRegistrar.Enabled = false;
                btnDelete.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Visible = false;
                lblEstado.Visible = false;
                cmbEstado.Visible = false;
                cmbEstado.SelectedIndex = 0;
                txtCorreo.Enabled = false;
                btnAdmin.Visible = false;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                
            }
            else if (id == 2)
            {
                DataTable dt = new DataTable();
                BLprofesores bLprofesores = new BLprofesores();
                bLprofesores.buscarProfesoresText(ref dt, txtBuscar.Text);
                dgvProfesores.DataSource = null;
                dgvProfesores.DataSource = dt;
                dgvProfesores.Refresh();

                txtApellido.Text = null;
                txtNombre.Text = null;
                txtNumdoc.Text = null;
                txtTelefono.Text = null;
                txtCorreo.Text = null;
                btnRegistrar.Enabled = true;
                btnDelete.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Visible = false;
                lblEstado.Visible = false;
                cmbEstado.Visible = false;
                cmbEstado.SelectedIndex = 0;
                btnAdmin.Visible = false;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                txtId.Text = null;

            }
            else if(id==1)
            {
                DataTable dt = new DataTable();
                BLprofesores bLprofesores = new BLprofesores();
                bLprofesores.buscarProfesoresText(ref dt, txtBuscar.Text);
                dgvProfesores.DataSource = null;
                dgvProfesores.DataSource = dt;
                dgvProfesores.Refresh();

                txtApellido.Text = null;
                txtNombre.Text = null;
                txtNumdoc.Text = null;
                txtTelefono.Text = null;
                txtCorreo.Text = null;
                btnRegistrar.Enabled = true;
                btnDelete.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Visible = false;
                lblEstado.Enabled = false;
                cmbEstado.Enabled = false;
                btnAdmin.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                txtId.Text = null;
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            clear();
        }
       
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro de eliminar?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                
                string Id_profesor = txtId.Text;
                bLprofesores.deletProfesor(Id_profesor);
                clear();
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro de Editar?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (txtApellido.Text.Equals("") | txtNombre.Text.Equals("") | txtNumdoc.Text.Equals("") | txtTelefono.Equals(""))
                {
                    MessageBox.Show("Llene los campos por favor", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else
                {
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    string Num_doc = txtNumdoc.Text;
                    string Telefono = txtTelefono.Text;
                    string Correo = txtCorreo.Text;
                    string Estado = cmbEstado.Text;
                    string Id_profesor = txtId.Text;
                    bEprofesores = new BEprofesores(Id_profesor, Nombre, Apellido, Num_doc, Telefono, Correo,Estado);
                    bLprofesores.updateProfesor(bEprofesores);
                    
                    clear();
                }
                
            }

            
        }
        

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void dgvProfesores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (id == 2)
            {
                btnCancelar.Visible = true;
                int ids = Convert.ToInt32(dgvProfesores.CurrentRow.Index);
                txtId.Text = dgvProfesores.Rows[ids].Cells[0].Value.ToString();
                txtNombre.Text = dgvProfesores.Rows[ids].Cells[1].Value.ToString();
                txtApellido.Text = dgvProfesores.Rows[ids].Cells[2].Value.ToString();
                txtNumdoc.Text = dgvProfesores.Rows[ids].Cells[3].Value.ToString();
                txtTelefono.Text = dgvProfesores.Rows[ids].Cells[4].Value.ToString();
                txtCorreo.Text = dgvProfesores.Rows[ids].Cells[5].Value.ToString();
                cmbEstado.Text = dgvProfesores.Rows[ids].Cells[6].Value.ToString();

                btnRegistrar.Enabled = false;
                btnDelete.Enabled = true;
                btnEditar.Enabled = true;
            }
            else if (id == 1)
            {
                btnCancelar.Visible = true;
                int ids = Convert.ToInt32(dgvProfesores.CurrentRow.Index);
                txtId.Text = dgvProfesores.Rows[ids].Cells[0].Value.ToString();
                txtNombre.Text = dgvProfesores.Rows[ids].Cells[1].Value.ToString();
                txtApellido.Text = dgvProfesores.Rows[ids].Cells[2].Value.ToString();
                txtNumdoc.Text = dgvProfesores.Rows[ids].Cells[3].Value.ToString();
                txtTelefono.Text = dgvProfesores.Rows[ids].Cells[4].Value.ToString();
                txtCorreo.Text = dgvProfesores.Rows[ids].Cells[5].Value.ToString();
                cmbEstado.Text = dgvProfesores.Rows[ids].Cells[6].Value.ToString();

                btnRegistrar.Enabled = false;
                btnDelete.Enabled = true;
                btnEditar.Enabled = true;
                btnAdmin.Enabled = true;
                cmbEstado.Enabled = true;
                lblEstado.Enabled = true;
            }
            
            

            
        }

        private void dgvProfesores_SizeChanged(object sender, EventArgs e)
        {
            btnEditar.Location = new Point(28, dgvProfesores.Size.Height + 200);
            btnDelete.Location = new Point(125, dgvProfesores.Size.Height + 200);
            btnCancelar.Location = new Point(222, dgvProfesores.Size.Height + 200);
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string codigo = txtId.Text;
            bLprofesores.EliminarProfesor(codigo);
            clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtNumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&&(e.KeyChar!=(char)Keys.Back))
            {
                e.Handled = true;
            }
            
            
            

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
