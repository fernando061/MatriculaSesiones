namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    partial class FormProfesor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSProfesor = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSProfesor();
            this.ReporteProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteProfesorTableAdapter = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSProfesorTableAdapters.ReporteProfesorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProfesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 38;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteProfesorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoSanMarcos.Formularios.MenuPrincipal.ReportProfesor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSProfesor
            // 
            this.DSProfesor.DataSetName = "DSProfesor";
            this.DSProfesor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteProfesorBindingSource
            // 
            this.ReporteProfesorBindingSource.DataMember = "ReporteProfesor";
            this.ReporteProfesorBindingSource.DataSource = this.DSProfesor;
            // 
            // ReporteProfesorTableAdapter
            // 
            this.ReporteProfesorTableAdapter.ClearBeforeFill = true;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.Load += new System.EventHandler(this.FormProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProfesorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteProfesorBindingSource;
        private DSProfesor DSProfesor;
        private DSProfesorTableAdapters.ReporteProfesorTableAdapter ReporteProfesorTableAdapter;
    }
}