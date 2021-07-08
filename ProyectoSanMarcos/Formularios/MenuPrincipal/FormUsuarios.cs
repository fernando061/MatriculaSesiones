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
namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }
        private BEusuario bEusuario = new BEusuario();
        private BLusuarios bLusuarios = new BLusuarios();
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            DataTable data = new DataTable();
            bLusuarios.CargosCmb(ref data);
            cmbCargo.DataSource = data;
            cmbCargo.DisplayMember = "Cargo";
            cmbCargo.ValueMember = "Id_cargo";
            DataTable dt = new DataTable();
            bLusuarios.buscarUsuarioText(ref dt,txtBuscar.Text);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Refresh();
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtConfContraseña.Text = null;
            txtContraseña.Text = null;
            txtCorreo.Text = null;
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            cmbCargo.SelectedIndex = 0;
            btnEditar.Enabled = false;
            btnCancelar.Visible = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals("")| txtApellido.Text.Equals("") | txtCorreo.Text.Equals("")|txtContraseña.Text.Equals("")|txtConfContraseña.Text.Equals("")
               )
            {
                MessageBox.Show("Llene todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtContraseña.Text.Equals(txtConfContraseña.Text))
                {
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    string Correo = txtCorreo.Text;
                    string Contraseña = txtContraseña.Text;
                    int cargo =Convert.ToInt32(cmbCargo.SelectedValue);

                    bEusuario = new BEusuario(Nombre,Apellido,Correo,Contraseña,cargo);
                    bLusuarios.InsertUsuarios(bEusuario);
                    Cargar();
                }
                else
                {
                    MessageBox.Show("La contraseña no concuerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Index);

            txtNombre.Text = dgvUsuarios.Rows[id].Cells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.Rows[id].Cells[2].Value.ToString();
            txtCorreo.Text = dgvUsuarios.Rows[id].Cells[3].Value.ToString();
            txtContraseña.Text = dgvUsuarios.Rows[id].Cells[4].Value.ToString();
            txtConfContraseña.Text = dgvUsuarios.Rows[id].Cells[4].Value.ToString();
            cmbEstado.Text= dgvUsuarios.Rows[id].Cells[5].Value.ToString();
            cmbCargo.Text = dgvUsuarios.Rows[id].Cells[6].Value.ToString();
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Visible = true;
            cmbEstado.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") | txtApellido.Text.Equals("") | txtCorreo.Text.Equals("") | txtContraseña.Text.Equals("") | txtConfContraseña.Text.Equals(""))
            {
                MessageBox.Show("Llene todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtContraseña.Text.Equals(txtConfContraseña.Text))
                {
                    int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Index);

                    int idc = Convert.ToInt32(dgvUsuarios.Rows[id].Cells[0].Value.ToString());
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    string Correo = txtCorreo.Text;
                    string Contraseña = txtContraseña.Text;
                    int cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    string Estado=cmbEstado.Text;
                    bEusuario = new BEusuario(idc,Nombre, Apellido, Correo, Contraseña, Estado, cargo);
                    bLusuarios.UpdateUsuario(bEusuario);
                    Cargar();
                }
                else
                {
                    MessageBox.Show("La contraseña no concuerda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Index);
                int idc = Convert.ToInt32(dgvUsuarios.Rows[id].Cells[0].Value.ToString());
                bLusuarios.DeletUsuario(idc);
                Cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void dgvUsuarios_SizeChanged(object sender, EventArgs e)
        {
            btnEditar.Location = new Point(28, dgvUsuarios.Size.Height + 220);
            btnEliminar.Location = new Point(125, dgvUsuarios.Size.Height + 220);
            btnCancelar.Location = new Point(222, dgvUsuarios.Size.Height + 220);
        }
    }
}
