namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumdoc = new System.Windows.Forms.MaskedTextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkProfesor = new System.Windows.Forms.CheckBox();
            this.chkAlumno = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.chkCurso = new System.Windows.Forms.CheckBox();
            this.chkBanco = new System.Windows.Forms.CheckBox();
            this.txtBanco = new System.Windows.Forms.MaskedTextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumdoc
            // 
            this.txtNumdoc.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumdoc.Location = new System.Drawing.Point(366, 146);
            this.txtNumdoc.Name = "txtNumdoc";
            this.txtNumdoc.Size = new System.Drawing.Size(153, 25);
            this.txtNumdoc.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(272, 261);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(133, 32);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Seleccionar",
            "Activo",
            "Eliminado"});
            this.cmbEstado.Location = new System.Drawing.Point(366, 93);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 6;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(209, 153);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 18);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "REPORTES";
            // 
            // chkProfesor
            // 
            this.chkProfesor.AutoSize = true;
            this.chkProfesor.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProfesor.ForeColor = System.Drawing.Color.White;
            this.chkProfesor.Location = new System.Drawing.Point(651, 93);
            this.chkProfesor.Name = "chkProfesor";
            this.chkProfesor.Size = new System.Drawing.Size(160, 22);
            this.chkProfesor.TabIndex = 10;
            this.chkProfesor.Text = "Reporte de profesor";
            this.chkProfesor.UseVisualStyleBackColor = true;
            this.chkProfesor.CheckedChanged += new System.EventHandler(this.chkProfesor_CheckedChanged);
            // 
            // chkAlumno
            // 
            this.chkAlumno.AutoSize = true;
            this.chkAlumno.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlumno.ForeColor = System.Drawing.Color.White;
            this.chkAlumno.Location = new System.Drawing.Point(651, 149);
            this.chkAlumno.Name = "chkAlumno";
            this.chkAlumno.Size = new System.Drawing.Size(150, 22);
            this.chkAlumno.TabIndex = 12;
            this.chkAlumno.Text = "Reporte de alumno";
            this.chkAlumno.UseVisualStyleBackColor = true;
            this.chkAlumno.CheckedChanged += new System.EventHandler(this.chkAlumno_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(209, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 18);
            this.label.TabIndex = 13;
            this.label.Text = "Estado:";
            // 
            // chkCurso
            // 
            this.chkCurso.AutoSize = true;
            this.chkCurso.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurso.ForeColor = System.Drawing.Color.White;
            this.chkCurso.Location = new System.Drawing.Point(651, 197);
            this.chkCurso.Name = "chkCurso";
            this.chkCurso.Size = new System.Drawing.Size(139, 22);
            this.chkCurso.TabIndex = 14;
            this.chkCurso.Text = "Reporte de curso";
            this.chkCurso.UseVisualStyleBackColor = true;
            this.chkCurso.CheckedChanged += new System.EventHandler(this.chkCurso_CheckedChanged);
            // 
            // chkBanco
            // 
            this.chkBanco.AutoSize = true;
            this.chkBanco.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBanco.ForeColor = System.Drawing.Color.White;
            this.chkBanco.Location = new System.Drawing.Point(651, 241);
            this.chkBanco.Name = "chkBanco";
            this.chkBanco.Size = new System.Drawing.Size(142, 22);
            this.chkBanco.TabIndex = 15;
            this.chkBanco.Text = "Reporte de Banco";
            this.chkBanco.UseVisualStyleBackColor = true;
            this.chkBanco.CheckedChanged += new System.EventHandler(this.chkBanco_CheckedChanged);
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(366, 197);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(153, 25);
            this.txtBanco.TabIndex = 16;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.White;
            this.lblBanco.Location = new System.Drawing.Point(209, 197);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(51, 18);
            this.lblBanco.TabIndex = 17;
            this.lblBanco.Text = "Banco:";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(823, 343);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.chkBanco);
            this.Controls.Add(this.chkCurso);
            this.Controls.Add(this.label);
            this.Controls.Add(this.chkAlumno);
            this.Controls.Add(this.chkProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtNumdoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtNumdoc;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkProfesor;
        private System.Windows.Forms.CheckBox chkAlumno;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox chkCurso;
        private System.Windows.Forms.CheckBox chkBanco;
        private System.Windows.Forms.MaskedTextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
    }
}