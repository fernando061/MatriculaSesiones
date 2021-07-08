namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    partial class FormRProfesores
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
            this.DSprofesores = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSprofesores();
            this.ReporteProfesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteProfesoresTableAdapter = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSprofesoresTableAdapters.ReporteProfesoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSprofesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProfesoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteProfesoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoSanMarcos.Formularios.MenuPrincipal.ReportProfesores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSprofesores
            // 
            this.DSprofesores.DataSetName = "DSprofesores";
            this.DSprofesores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteProfesoresBindingSource
            // 
            this.ReporteProfesoresBindingSource.DataMember = "ReporteProfesores";
            this.ReporteProfesoresBindingSource.DataSource = this.DSprofesores;
            // 
            // ReporteProfesoresTableAdapter
            // 
            this.ReporteProfesoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormRProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRProfesores";
            this.Text = "FormProfesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSprofesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProfesoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSprofesores DSprofesores;
        private System.Windows.Forms.BindingSource ReporteProfesoresBindingSource;
        private DSprofesoresTableAdapters.ReporteProfesoresTableAdapter ReporteProfesoresTableAdapter;
    }
}