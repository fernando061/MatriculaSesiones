namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    partial class ReporteAlumnos
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
            this.ReportAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSAlumnos = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSAlumnos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportAlumnosTableAdapter = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSAlumnosTableAdapters.ReportAlumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportAlumnosBindingSource
            // 
            this.ReportAlumnosBindingSource.DataMember = "ReportAlumnos";
            this.ReportAlumnosBindingSource.DataSource = this.DSAlumnos;
            // 
            // DSAlumnos
            // 
            this.DSAlumnos.DataSetName = "DSAlumnos";
            this.DSAlumnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 28;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportAlumnosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoSanMarcos.Formularios.MenuPrincipal.ReportAlumnos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(865, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportAlumnosTableAdapter
            // 
            this.ReportAlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlumnos";
            this.Text = "ReporteAlumnos";
            this.Load += new System.EventHandler(this.ReporteAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportAlumnosBindingSource;
        private DSAlumnos DSAlumnos;
        private DSAlumnosTableAdapters.ReportAlumnosTableAdapter ReportAlumnosTableAdapter;
    }
}