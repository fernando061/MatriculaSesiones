using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using DB;
namespace BL
{
    public class BLreportes
    {
        public void ReporteAlumno(ref DataTable dt, string DNI)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("ReportAlumno", sqlConn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Numdoc", DNI);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }

        }
        public void SumaAlumno(ref DataTable dt, string DNI)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SumaAlumno", sqlConn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Numdoc", DNI);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }

        }
        public void NumACurso(ref DataTable dt, string Curso)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("NumACurso", sqlConn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Curso", Curso);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }

        }
    }
}
