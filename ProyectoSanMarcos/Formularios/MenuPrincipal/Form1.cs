﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Curso { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.NumACurso' Puede moverla o quitarla según sea necesario.
            this.NumACursoTableAdapter.Fill(this.DataSet1.NumACurso,Curso);



            this.reportViewer1.RefreshReport();
        }
    }
}
