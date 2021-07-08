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
using System.IO;
using System.Diagnostics;

namespace ProyectoSanMarcos.Formularios.Matriculas
{
    public partial class FormMatricula : Form
    {
        private int id;
        public FormMatricula(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private BEmatricula bEmatricula = new BEmatricula();
        private BLMatriculas bLMatriculas = new BLMatriculas();
        private BEalumno bEalumno = new BEalumno();
        private BLalumnos bLalumnos = new BLalumnos();
        private void FormMatricula_Load(object sender, EventArgs e)
        { 
            cargar();
           
        }
        public void cargar()
        {
            
            txtId.Enabled = false;
            if (id == 3)
            {
                DataTable dt = new DataTable();
                bLMatriculas.buscarMatriculaText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                dgvMatricula.Refresh();
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtNumdoc.Enabled = false;
                txtCorreo.Enabled = false;
                txtTelefono.Enabled = false;
                txtMonto.Enabled = false;
                txtBancoDep.Enabled = false;
                txtNumOperacion.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Visible = false;
                btnGuardar.Enabled = false;
                DataTable data = new DataTable();
                BLcursos bLcursos = new BLcursos();
                bLcursos.CursosCmb(ref data);
                cmbCurso.DataSource = data;
                cmbCurso.DisplayMember = "Nombre_curso";
                cmbCurso.ValueMember = "ID_curso";
                cmbCurso.Enabled = false;
                dtpFechDeposito.Enabled = false;
                btnAbrir.Visible = false;
                txtBaucher.Enabled = false;
                btnPath.Visible = false;
                btnPath.Text = "...";
                
            }
            else if (id == 2)
            {
                DataTable dt = new DataTable();
                bLMatriculas.buscarMatriculaText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                dgvMatricula.Refresh();
                txtNombre.Text = null;
                txtApellido.Text = null;
                txtNumdoc.Text = null;
                txtCorreo.Text = null;
                txtTelefono.Text = null;
                txtMonto.Text = null;
                txtBancoDep.Text = null;
                txtNumOperacion.Text = null;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Visible = false;
                btnGuardar.Enabled = true;
                DataTable data = new DataTable();
                BLcursos bLcursos = new BLcursos();
                bLcursos.CursosCmb(ref data);
                cmbCurso.DataSource = data;
                cmbCurso.DisplayMember = "Nombre_curso";
                cmbCurso.ValueMember = "ID_curso";
                txtId.Text = null;
                btnAbrir.Enabled = false;
                txtBaucher.Enabled = false;
                btnPath.Text = "...";
                dtpFechDeposito.Text = DateTime.Now.ToString();

            }
            else if (id == 1)
            {
                DataTable dt = new DataTable();
                bLMatriculas.buscarMatriculaText(ref dt, txtBuscar.Text);
                dgvMatricula.DataSource = null;
                dgvMatricula.DataSource = dt;
                
                dgvMatricula.Refresh();
                
                txtNombre.Text = null;
                txtApellido.Text = null;
                txtNumdoc.Text = null;
                txtCorreo.Text = null;
                txtTelefono.Text = null;
                txtMonto.Text = null;
                txtBancoDep.Text = null;
                txtNumOperacion.Text = null;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Visible = false;
                btnGuardar.Enabled = true;
                DataTable data = new DataTable();
                BLcursos bLcursos = new BLcursos();
                bLcursos.CursosCmb(ref data);
                cmbCurso.DataSource = data;
                cmbCurso.DisplayMember = "Nombre_curso";
                cmbCurso.ValueMember = "ID_curso";
                cmbEstado.SelectedIndex = 0;
                cmbEstado.Enabled = false;
                cmbEstado.Visible = true;
                lblEstado.Enabled = false;
                cmbEstado.Visible = true;
                lblEstado.Visible = true;
                txtId.Text = null;
                txtBaucher.Text = null;
                btnAbrir.Enabled = false;
                txtBaucher.Enabled = false;
                btnPath.Text = "...";
                dtpFechDeposito.Text = DateTime.Now.ToString();
            }
            



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            byte[] file=null;
            string extencion = "";

            if (txtBaucher.Text.Trim().Equals(""))
            {
                file = BitConverter.GetBytes(0);
                extencion = "";
            }
            else
            {
                
                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();

                }
                extencion = openFileDialog1.SafeFileName;
            }
            

            if (txtApellido.Text.Equals("") | txtBancoDep.Equals("") | txtCorreo.Text.Equals("") | txtNombre.Text.Equals("") | txtTelefono.Text.Equals("") | txtMonto.Text.Equals("") | txtNumOperacion.Text.Equals("")|txtCorreo.Text.Equals("")|cmbCurso.SelectedIndex==0)
            {
                MessageBox.Show("Llene todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string Nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string NumDoc = txtNumdoc.Text;
                string Correo = txtCorreo.Text;
                string Telefono = txtTelefono.Text;
                DateTime fechDeposito = Convert.ToDateTime(dtpFechDeposito.Text);
                decimal Monto = Convert.ToDecimal(txtMonto.Text);
                string bancoDeposito = txtBancoDep.Text;
                string numeroO = txtNumOperacion.Text;
                int Id_curso = Convert.ToInt32(cmbCurso.SelectedValue);
                BEmatricula bEmatricula = new BEmatricula(Nombre, apellido,NumDoc, Correo, Telefono, fechDeposito, Monto, bancoDeposito, numeroO, Id_curso,file,extencion);
                try
                {
                    bLMatriculas.InsertMatricula(bEmatricula);
                    cargar();
                    int result = 0;
                    int longi = dgvMatricula.Rows.Count;
                    result = longi - 2;
                    string codigo = dgvMatricula.Rows[result].Cells[0].Value.ToString();
                    bEalumno = new BEalumno(Nombre, apellido, NumDoc, Telefono, bLMatriculas.getIdMatricula(codigo), Id_curso);
                    bLalumnos.InsertAlumno(bEalumno);
                }
                catch (Exception)
                {

                    MessageBox.Show("error");
                }
                
                

            }





        }

        

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (txtApellido.Text.Equals("") | txtBancoDep.Equals("") | txtCorreo.Text.Equals("") | txtNombre.Text.Equals("") | txtTelefono.Text.Equals("") | txtMonto.Text.Equals("") | txtNumOperacion.Text.Equals("") | cmbCurso.SelectedIndex == 0)
            {
                MessageBox.Show("Llene todos los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                int id = Convert.ToInt32(dgvMatricula.CurrentRow.Index);

                string IdMatricula = dgvMatricula.Rows[id].Cells[0].Value.ToString();
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string NumDoc = txtNumdoc.Text;
                string Correo = txtCorreo.Text;
                string Telefono = txtTelefono.Text;
                DateTime fechDeposito = Convert.ToDateTime(dtpFechDeposito.Text);
                decimal Monto = Convert.ToDecimal(txtMonto.Text);
                string bancoDeposito = txtBancoDep.Text;
                string numeroO = txtNumOperacion.Text;
                string Estado = cmbEstado.Text;
                int id_curso = Convert.ToInt32(cmbCurso.SelectedValue);
                bEmatricula = new BEmatricula(IdMatricula,Nombre,Apellido,NumDoc,Correo,Telefono,fechDeposito,Monto,bancoDeposito,numeroO,id_curso,Estado);
                bLMatriculas.UpdateMatricula(bEmatricula);
                MessageBox.Show(bLMatriculas.getIdMatricula(IdMatricula).ToString());
                BEalumno bEalumno = new BEalumno(Nombre,Apellido,NumDoc,Telefono,Estado,bLMatriculas.getIdMatricula(IdMatricula),id_curso);
                bLalumnos.UpdateAlumno(bEalumno);
                cargar();
               

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(dgvMatricula.CurrentRow.Index);

            string IdMatricula = dgvMatricula.Rows[id].Cells[0].Value.ToString();
            bLMatriculas.DeletMatricula(IdMatricula);
            bLalumnos.deletAlumno(bLMatriculas.getIdMatricula(IdMatricula));
            MessageBox.Show("Matricula Eliminada");
            cargar();
        }

        private void dgvMatricula_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            
            if (id == 2)
            {
                int ids = Convert.ToInt32(dgvMatricula.CurrentRow.Index);
                txtId.Text= dgvMatricula.Rows[ids].Cells[0].Value.ToString();
                txtNombre.Text = dgvMatricula.Rows[ids].Cells[1].Value.ToString();
                txtApellido.Text = dgvMatricula.Rows[ids].Cells[2].Value.ToString();
                txtNumdoc.Text = dgvMatricula.Rows[ids].Cells[3].Value.ToString();
                txtCorreo.Text = dgvMatricula.Rows[ids].Cells[4].Value.ToString();
                txtTelefono.Text = dgvMatricula.Rows[ids].Cells[5].Value.ToString();
                dtpFechDeposito.Text = dgvMatricula.Rows[ids].Cells[6].Value.ToString();
                txtMonto.Text = dgvMatricula.Rows[ids].Cells[7].Value.ToString();
                txtBancoDep.Text = dgvMatricula.Rows[ids].Cells[8].Value.ToString();
                txtNumOperacion.Text = dgvMatricula.Rows[ids].Cells[9].Value.ToString();
                cmbEstado.Text = dgvMatricula.Rows[ids].Cells[10].Value.ToString();
                string CodCurso = dgvMatricula.Rows[ids].Cells[11].Value.ToString();
                BLcursos bLcursos = new BLcursos();
                cmbCurso.SelectedValue = bLcursos.CodCurso(CodCurso).ToString();
                btnCancelar.Visible = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;
                btnAbrir.Enabled = true;
                btnPath.Text = "Editar archivo";
            }
            else if (id == 1)
            {
                int ids = Convert.ToInt32(dgvMatricula.CurrentRow.Index);
                txtId.Text = dgvMatricula.Rows[ids].Cells[0].Value.ToString();
                txtNombre.Text = dgvMatricula.Rows[ids].Cells[1].Value.ToString();
                txtApellido.Text = dgvMatricula.Rows[ids].Cells[2].Value.ToString();
                txtNumdoc.Text = dgvMatricula.Rows[ids].Cells[3].Value.ToString();
                txtCorreo.Text = dgvMatricula.Rows[ids].Cells[4].Value.ToString();
                txtTelefono.Text = dgvMatricula.Rows[ids].Cells[5].Value.ToString();
                dtpFechDeposito.Text = dgvMatricula.Rows[ids].Cells[6].Value.ToString();
                txtMonto.Text = dgvMatricula.Rows[ids].Cells[7].Value.ToString();
                txtBancoDep.Text = dgvMatricula.Rows[ids].Cells[8].Value.ToString();
                txtNumOperacion.Text = dgvMatricula.Rows[ids].Cells[9].Value.ToString();
                cmbEstado.Text = dgvMatricula.Rows[ids].Cells[10].Value.ToString();
                string CodCurso = dgvMatricula.Rows[ids].Cells[11].Value.ToString();
                BLcursos bLcursos = new BLcursos();
                cmbCurso.SelectedValue = bLcursos.CodCurso(CodCurso).ToString();
                btnCancelar.Visible = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;
                cmbEstado.Enabled = true;
                lblEstado.Enabled = true;
                btnAbrir.Enabled = true;
                btnPath.Text = "Editar archivo";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLMatriculas.Costo(txtMonto,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnPath.Text == "...")
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Todos los archivos(*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtBaucher.Text = openFileDialog1.FileName;
                }
            }
            else if(btnPath.Text.Equals("Editar archivo"))
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Todos los archivos(*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtBaucher.Text = openFileDialog1.FileName;
                }
                byte[] file = null;

                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();

                }
                string extencion = openFileDialog1.SafeFileName;
                bLMatriculas.UpdateFile(bLMatriculas.getIdMatricula(txtId.Text), file, extencion);
            }
            
        }

        

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                BEprueba bEprueba = bLMatriculas.finFile(bLMatriculas.getIdMatricula(txtId.Text));
                string fullpath = folder + bEprueba.exten;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (File.Exists(folder))
                {
                    Directory.Delete(fullpath);
                }
                byte[] file = bEprueba.file;
                File.WriteAllBytes(fullpath, file);
                Process.Start(fullpath);
            }
            catch (Exception)
            {

                MessageBox.Show("No hay archivo","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] file=null;

            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();

            }
            string extencion = openFileDialog1.SafeFileName;
            bLMatriculas.UpdateFile(bLMatriculas.getIdMatricula(txtId.Text), file, extencion);
        }

        private void dgvMatricula_SizeChanged(object sender, EventArgs e)
        {
            btnEditar.Location = new Point(28, dgvMatricula.Size.Height + 190);
            btnEliminar.Location = new Point(125, dgvMatricula.Size.Height + 190);
            btnCancelar.Location = new Point(222, dgvMatricula.Size.Height + 190);
            btnAbrir.Location = new Point(531, dgvMatricula.Size.Height + 190);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
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

        private void txtNumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
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
