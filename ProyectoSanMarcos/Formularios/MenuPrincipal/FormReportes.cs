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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (chkCurso.Checked & cmbEstado.Text.Equals("Seleccionar"))
            {
                Form1 frm=new Form1();
                frm.Curso = txtNumdoc.Text;
                frm.ShowDialog();

            }
            else if (chkCurso.Checked && cmbEstado.Text.Equals("Activo")||cmbEstado.Text.Equals("Eliminado")& !chkAlumno.Checked & !chkProfesor.Checked)
            {
                frmRACE race = new frmRACE();
                race.Curso = txtNumdoc.Text;
                race.Estado = cmbEstado.Text;
                race.ShowDialog();
            }
            if (chkAlumno.Checked & cmbEstado.Text.Equals("Seleccionar"))
            {
                FormReportAlumno alumno = new FormReportAlumno();
                alumno.DNI = txtNumdoc.Text;
                alumno.ShowDialog();
            }
            else if (chkAlumno.Checked && cmbEstado.Text.Equals("Activo") || cmbEstado.Text.Equals("Eliminado") & !chkCurso.Checked &!chkProfesor.Checked)
            {
                ReporteAlumnos alumno = new ReporteAlumnos();
                alumno.Estado = cmbEstado.Text;
                alumno.ShowDialog();
            }
            else if(chkProfesor.Checked& cmbEstado.Text.Equals("Seleccionar"))
            {
                FormProfesor profesor = new FormProfesor();
                profesor.DNI = txtNumdoc.Text;
                profesor.ShowDialog();
            }
            else if(chkProfesor.Checked &cmbEstado.Text.Equals("Activo")|| cmbEstado.Text.Equals("Eliminado")&!chkAlumno.Checked & !chkCurso.Checked)
            {
                FormRProfesores profesores = new FormRProfesores();
                profesores.Estado = cmbEstado.Text;
                profesores.ShowDialog();
            }
            else if(chkBanco.Checked & cmbEstado.Text.Equals("Seleccionar"))
            {
                FormBanco banco = new FormBanco();
                banco.Banco = txtBanco.Text;
                banco.Curso = txtNumdoc.Text;
                banco.ShowDialog();
            }


        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            txtNumdoc.Enabled = false;
            cmbEstado.Enabled = false;
            btnReporte.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            lblBanco.Enabled = false;
            txtBanco.Enabled = false;

        }

        private void chkAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlumno.Checked)
            {
                txtNumdoc.Enabled = true;
                btnReporte.Enabled = true;
                chkProfesor.Enabled = false;
                chkCurso.Enabled = false;
                cmbEstado.Enabled = true;
                chkBanco.Enabled = false;
                
            }
            else
            {
                chkBanco.Enabled = true;
                txtNumdoc.Enabled = false;
                btnReporte.Enabled = false;
                chkProfesor.Enabled = true;
                chkCurso.Enabled = true;
                cmbEstado.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                txtNumdoc.Text = null;
            }
        }

        private void chkCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurso.Checked)
            {
                chkBanco.Enabled = false;
                lblTipo.Text = "Nombre del curso:";
                txtNumdoc.Enabled = true;
                btnReporte.Enabled = true;
                cmbEstado.Enabled = true;
                chkAlumno.Enabled = false;
                chkProfesor.Enabled = false;
            }
            else
            {
                chkBanco.Enabled = true;
                lblTipo.Text = "DNI:";
                txtNumdoc.Enabled = false;
                btnReporte.Enabled = false;
                cmbEstado.Enabled = false;
                txtNumdoc.Text = null;
                cmbEstado.SelectedIndex = 0;
                chkAlumno.Enabled = true;
                chkProfesor.Enabled = true;
            }
        }

        private void chkProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProfesor.Checked)
            {
                chkBanco.Enabled = false;
                btnReporte.Enabled = true;
                cmbEstado.Enabled = true;
                chkAlumno.Enabled = false;
                chkCurso.Enabled = false;
                txtNumdoc.Enabled = true;
            }
            else
            {
                chkBanco.Enabled = true;
                btnReporte.Enabled = false;
                cmbEstado.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                chkAlumno.Enabled = true;
                chkCurso.Enabled = true;
                txtNumdoc.Enabled = false;
                txtNumdoc.Text = null;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex>0 &!chkCurso.Checked){
                txtNumdoc.Enabled = false;
                txtNumdoc.Text = null;
            }
            else
            {
                txtNumdoc.Enabled = true;
            }
        }

        private void chkBanco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBanco.Checked)
            {
                chkProfesor.Enabled = false;
                chkCurso.Enabled = false;
                chkAlumno.Checked = false;
                lblTipo.Text = "Nombre del curso:";
                txtBanco.Text = null;
                lblBanco.Enabled = true;
                txtBanco.Enabled = true;
                btnReporte.Enabled = true;
                lblBanco.Enabled = true;
            }
            else
            {
                lblTipo.Text = "DNI:";
                txtBanco.Text = null;
                lblBanco.Enabled = false;
                txtBanco.Enabled = false;
                btnReporte.Enabled = false;
                chkProfesor.Enabled = true;
                chkCurso.Enabled = true;
                chkAlumno.Checked = true;
            }
        }
    }
}
