﻿namespace ProyectoSanMarcos.Formularios.MenuPrincipal
{
    partial class FormBanco
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
            this.DSBanco = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSBanco();
            this.bancoReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoReportTableAdapter = new ProyectoSanMarcos.Formularios.MenuPrincipal.DSBancoTableAdapters.bancoReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bancoReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoSanMarcos.Formularios.ReportBanco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSBanco
            // 
            this.DSBanco.DataSetName = "DSBanco";
            this.DSBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoReportBindingSource
            // 
            this.bancoReportBindingSource.DataMember = "bancoReport";
            this.bancoReportBindingSource.DataSource = this.DSBanco;
            // 
            // bancoReportTableAdapter
            // 
            this.bancoReportTableAdapter.ClearBeforeFill = true;
            // 
            // FormBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBanco";
            this.Text = "FormBanco";
            this.Load += new System.EventHandler(this.FormBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bancoReportBindingSource;
        private DSBanco DSBanco;
        private DSBancoTableAdapters.bancoReportTableAdapter bancoReportTableAdapter;
    }
}