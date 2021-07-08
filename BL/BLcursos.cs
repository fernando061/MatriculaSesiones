using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DB;
using BE;
using System.Windows.Forms;
namespace BL
{
    public class BLcursos
    {
        public void CursosCmb(ref DataTable dt)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cursos", sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);



                DataRow fila = dt.NewRow();
                fila["Nombre_curso"] = "Seleccionar Curso";
                dt.Rows.InsertAt(fila, 0);



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
        public void buscarCursoText(ref DataTable dt, string buscador)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("buscarCursoText", sqlConn);

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
        public void deletCurso(string id)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();
                    SqlCommand sqlComm = sqlConn.CreateCommand();
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.CommandText = "deletCurso";
                    sqlComm.Parameters.AddWithValue("@CODCURSO", id);
                    int rows = sqlComm.ExecuteNonQuery();

                    if (rows == 1)
                    {
                        MessageBox.Show("Curso Eliminado");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            
            
        }
        public void insertarCurso(BEcursos bEcursos)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "insertCurso";                
                sqlCom.Parameters.AddWithValue("@Nombre_Curso", bEcursos.Nombre_curso);
                sqlCom.Parameters.AddWithValue("@Id_profesor", bEcursos.Id_Profesor);               
                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {
                    
                    MessageBox.Show("Curso Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);

            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void UpdateCurso(BEcursos bEcursos)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "updateCurso";
                sqlCom.Parameters.AddWithValue("@CODCURSO", bEcursos.CODCURSO);
                sqlCom.Parameters.AddWithValue("@Nombre_Curso", bEcursos.Nombre_curso);
                sqlCom.Parameters.AddWithValue("@Id_profesor", bEcursos.Id_Profesor);
                sqlCom.Parameters.AddWithValue("@Estado", bEcursos.Estado);
                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("Curso Actualizado");

                }




            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            finally
            {
                sqlConn.Close();
            }

        }
        public int getIDcurso(string curso)
        {
            int proId = 0;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();
                    SqlCommand sqlCom = sqlConn.CreateCommand();
                    sqlCom.CommandType = CommandType.Text;

                    sqlCom.CommandText = @"select ID_curso from Cursos where Nombre_curso=@Curso";
                    sqlCom.Parameters.AddWithValue("@Curso", curso);
                    SqlDataReader sqlDR = sqlCom.ExecuteReader();
                    if (sqlDR.Read())
                    {
                        proId = Convert.ToInt32(sqlDR[0]);
                    }


                    sqlConn.Close();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

            return proId;


        }
        public int CodCurso(string id)
        {

            int cod = 0;
            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_curso FROM Cursos where CODCURSO=@ID", sqlConn);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader sqlDR = cmd.ExecuteReader();
                if (sqlDR.Read())
                {
                    cod = Convert.ToInt32(sqlDR["ID_curso"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }
            return cod;

        }
        public string getcurso(int Idcurso)
        {
            string proId = "";
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();
                    SqlCommand sqlCom = sqlConn.CreateCommand();
                    sqlCom.CommandType = CommandType.Text;

                    sqlCom.CommandText = @"select Nombre_curso from Cursos where ID_curso=@Curso";
                    sqlCom.Parameters.AddWithValue("@Curso", Idcurso);
                    SqlDataReader sqlDR = sqlCom.ExecuteReader();
                    if (sqlDR.Read())
                    {
                        proId = sqlDR[0].ToString();
                        
                    }

                    


                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

            return proId;

        }
        public void EliminarCurso(string codigo)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "EliminarCurso";
                sqlCom.Parameters.AddWithValue("@CODCURSO", codigo);
                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {

                    MessageBox.Show("Curso Eliminado", "Eliminado", MessageBoxButtons.OK);

                }

            }
            catch (Exception )
            {

                MessageBox.Show("Este curso no se puede eliminar porque se esta usando en matricula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            finally
            {
                sqlConn.Close();
            }

        }

    }
}
