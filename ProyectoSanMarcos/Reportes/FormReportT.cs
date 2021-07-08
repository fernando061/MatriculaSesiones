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
namespace ProyectoSanMarcos.Reportes
{
    public partial class FormReportT : Form
    {
        public FormReportT()
        {
            InitializeComponent();
        }

        
        private void ReportAlumno()
        {
            ReportAlumno rptA = new ReportAlumno();
            DataTable dt = new DataTable();
            BLreportes rp = new BLreportes();
            rp.ReporteAlumno(ref dt, txtNumDoc.Text);
            DataTable data = new DataTable();
            rp.SumaAlumno(ref data, txtNumDoc.Text);
            
            
            rptA.table1.DataSource = dt;
            rptA.table2.DataSource = data;
            reportViewer1.Report = rptA;
            reportViewer1.RefreshReport();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportAlumno();
        }
    }
}
