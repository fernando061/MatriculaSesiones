using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DB;
using BE;
namespace BL
{
    public class BLalumnos
    {
        public void buscarAlumnoText(ref DataTable dt, string buscador)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("BuscarAlumno", sqlConn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
        public void InsertAlumno( BEalumno bEalumno)
        {
            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {
                

                sqlConn.Open();

                SqlCommand cmd = new SqlCommand("insertAlumnos", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", bEalumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", bEalumno.Apellido);
                cmd.Parameters.AddWithValue("@Num_doc", bEalumno.Numdoc);
                cmd.Parameters.AddWithValue("@Telefono", bEalumno.Telefono);
                cmd.Parameters.AddWithValue("@Id_curso", bEalumno.IdCurso);
                cmd.Parameters.AddWithValue("@Id_matricula", bEalumno.IdMatricula);
                int row = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                sqlConn.Close();
            }
            

        }
        public void UpdateAlumno(BEalumno bEalumno)
        {
            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {
                sqlConn.Open();

                SqlCommand cmd = new SqlCommand("updateAlumno", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Nombre", bEalumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", bEalumno.Apellido);
                cmd.Parameters.AddWithValue("@Num_doc", bEalumno.Numdoc);
                cmd.Parameters.AddWithValue("@Telefono", bEalumno.Telefono);
                cmd.Parameters.AddWithValue("@Estado", bEalumno.Estado);
                cmd.Parameters.AddWithValue("@Id_curso", bEalumno.IdCurso);
                cmd.Parameters.AddWithValue("@CODMATRICULA", bEalumno.IdMatricula);

                cmd.ExecuteNonQuery();
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
        public void deletAlumno(int id)
        {
            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {
                
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "deletAlumno";
                sqlComm.Parameters.AddWithValue("@Id_matricula", id);
                int rows = sqlComm.ExecuteNonQuery();
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
        public BEmapperMatricula FindById(string codigo)
        {
            BEmapperMatricula bEmapper = null;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();

                    SqlCommand sqlCom = sqlConn.CreateCommand();

                    sqlCom.CommandText = "select * from Matricula where CODMATRICULA=@ID";
                    sqlCom.Parameters.AddWithValue("@ID", codigo);


                    SqlDataReader sqlDR = sqlCom.ExecuteReader();


                    if (sqlDR.Read())
                    {
                        bEmapper = new BEmapperMatricula();
                        bEmapper.Nombre = sqlDR.GetString(2);
                        bEmapper.Apellido = sqlDR.GetString(3);
                        bEmapper.Correo = sqlDR.GetString(4);
                        bEmapper.Telefono = sqlDR.GetString(5);
                        bEmapper.Fecha_deposito = sqlDR.GetDateTime(6);
                        bEmapper.Monto = sqlDR.GetDecimal(7);
                        bEmapper.Banco_deposito = sqlDR.GetString(8);
                        bEmapper.Numero_operacion = sqlDR.GetString(9);
                        bEmapper.Estado = sqlDR.GetString(10);
                        bEmapper.Id_curso = sqlDR.GetInt32(11);
                    }

                    sqlConn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            


            return bEmapper;
        }
    }
}
