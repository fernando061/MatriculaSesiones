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
using ProyectoSanMarcos.Formularios.Bienvenida;
using ProyectoSanMarcos.Formularios.MenuPrincipal;

namespace ProyectoSanMarcos.Formularios.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void validacionLogin()
        {
            if (txtUsuario.Text == "" & txtPassword.Text == "")
            {
                lblError.Visible = true;
                lblError.Text=("Ingrese su Usuario y Contraseña por favor");

            }

            else if (txtUsuario.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = ("Ingrese Usuario");

            }
            else if (txtPassword.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = ("Ingrese Contraseña");
            }
         
            else
            {
                lblError.Visible = false;
                logear();
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                if (txtPassword.PasswordChar.Equals('*'))
                {
                    txtPassword.PasswordChar = '\0';
                }


            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            validacionLogin();
        }

        public void logear()
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;
            
            BLlogin bLlogin = new BLlogin();

            if (bLlogin.Login(user,pass) == true)
            {
                int id=bLlogin.IdUsuario(user, pass);
                
                FormBienvenida bienvenida = new FormBienvenida();
                this.Hide();
                bienvenida.ShowDialog();
                FormMenuPrincipal form = new FormMenuPrincipal(id);
                form.Show();
                


            }
            else if (bLlogin.Login(user,pass) == false)
            {
                txtPassword.Text = null;
                txtUsuario.Text = null;
                MessageBox.Show("Usuario o contraseña", "Facultad Ing. Electrica y Electronica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
