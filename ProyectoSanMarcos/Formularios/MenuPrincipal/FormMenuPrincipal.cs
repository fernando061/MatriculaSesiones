using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoSanMarcos.Formularios.Matriculas;
using ProyectoSanMarcos.Formularios.Profesores;
using ProyectoSanMarcos.Formularios.Cursos;
using ProyectoSanMarcos.Formularios.Alumnos;
using ProyectoSanMarcos.Reportes;

namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    public partial class FormMenuPrincipal : Form
    {
        private int id;
        public FormMenuPrincipal(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotonMaximizar.Visible = false;
            BotonRestaurar.Visible = true;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotonRestaurar.Visible = false;            
            BotonMaximizar.Visible = true;

        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BotonEscuelas_Click(object sender, EventArgs e)
        {

            FormMatricula formMatricula = new FormMatricula(id);
            formMatricula.Show();
            
        }

        private void BotonElectronica_Click(object sender, EventArgs e)
        {
            //CtrElectronica ctrElectronica = new CtrElectronica();
            //SubmenuEscuelas.Visible = false;
            //PanelContenedor.Controls.Clear();
            //ctrElectronica.Dock = DockStyle.Fill;
            //ctrElectronica.BringToFront();
            //PanelContenedor.Controls.Add(ctrElectronica);
           

        }

        

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FormProfesores form = new FormProfesores(id);
            form.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCusos form = new FormCusos(id);
            form.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos form = new FormAlumnos(id);
            form.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.Show();
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes report = new FormReportes();
            report.Show();
            //FormReportT frm = new FormReportT();
            //frm.ShowDialog();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (id == 1)
            {
                btnUsuarios.Visible = true;
            }
            else if (id == 3)
            {
                btnUsuarios.Visible = false;
            }
            else if (id == 2)
            {
                btnUsuarios.Visible = false;    
            }
            
            pbFondo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(pbFondo);
        }
    }
}
