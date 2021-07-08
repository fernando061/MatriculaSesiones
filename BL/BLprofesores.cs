using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;
using DB;
using System.Windows.Forms;

namespace BL
{
    public class BLprofesores
    {
        public void buscarProfesoresText(ref DataTable dt, string buscador)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {

                    sqlConn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("buscarProfesorText", sqlConn);

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@buscar", buscador);
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
        public void insertarProfesor(BEprofesores bEprofesores)
        {

            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {

                    sqlConn.Open();
                    SqlCommand sqlCom = sqlConn.CreateCommand();
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.CommandText = "InsertProfesor";
                    //sqlCom.Parameters.AddWithValue("@Id_profesores", bEprofesores.Id_profesores);
                    sqlCom.Parameters.AddWithValue("@Nombre", bEprofesores.Noombre);
                    sqlCom.Parameters.AddWithValue("@Apellido", bEprofesores.Apellido);
                    sqlCom.Parameters.AddWithValue("@Num_doc", bEprofesores.Num_doc);
                    sqlCom.Parameters.AddWithValue("@Telefono", bEprofesores.Telefono);
                    sqlCom.Parameters.AddWithValue("@Correo", bEprofesores.Correo);
                    int rows = sqlCom.ExecuteNonQuery();

                    if (rows == 1)
                    {

                        MessageBox.Show("Profesor Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }




                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
                

        }
        public string getIDProfesor()
        {
            string proId;
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;

                sqlCom.CommandText = "idDescProfesor";
                SqlDataReader sqlDR = sqlCom.ExecuteReader();

                if (sqlDR.Read())
                {

                    string id = sqlDR[0].ToString();
                    string n = "";
                    for (int x = 0; x < id.Length; x++)
                    {
                        if (x == 0 | x == 1)
                        {
                            continue;
                        }
                        else
                        {
                            n += id.Substring(x, 1);
                        }
                    }
                    int result = Convert.ToInt32(n) + 1;
                    //result = result + 2;


                    proId = "P0" + result.ToString();
                }
                else if (Convert.IsDBNull(sqlDR))
                {
                    proId = ("P01");
                }
                else
                {
                    proId = ("P01");
                }
                sqlConn.Close();
                return proId;
            }
            

        }
        public void deletProfesor(string id)
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "DeletProfesor";
                sqlComm.Parameters.AddWithValue("@Id", id);
                int rows = sqlComm.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("Profesor Eliminado");

                }
            }
            
        }
        public void updateProfesor(BEprofesores bEprofesores)
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.CommandText = "UpdateProfesor";
                sqlComm.Parameters.AddWithValue("@CODPROFESOR", bEprofesores.Id_profesores);
                sqlComm.Parameters.AddWithValue("@Nombre", bEprofesores.Noombre);
                sqlComm.Parameters.AddWithValue("@Apellido", bEprofesores.Apellido);
                sqlComm.Parameters.AddWithValue("@Num_doc", bEprofesores.Num_doc);
                sqlComm.Parameters.AddWithValue("@Telefono", bEprofesores.Telefono);
                sqlComm.Parameters.AddWithValue("@Correo", bEprofesores.Correo);
                sqlComm.Parameters.AddWithValue("@Estado", bEprofesores.Estado);
                int rows = sqlComm.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("Profesor Actualizado");
                }
            }
            
        }
        public void ProfesoresCmb(ref DataTable dt)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT *
FROM Profesores", sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);



                DataRow fila = dt.NewRow();
                fila["Apellido"] = "Seleccionar";
                dt.Rows.InsertAt(fila, 0);



            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }

        }
        public  int CodProfesor(string id)
        {

            int cod = 0;
            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_profesor FROM Profesores where CODPROFESOR=@ID", sqlConn);
                cmd.Parameters.AddWithValue("@ID",id);
                SqlDataReader sqlDR= cmd.ExecuteReader();
                if (sqlDR.Read())
                {
                    cod =Convert.ToInt32(sqlDR["ID_profesor"]);
                }

            }
            catch (Exception ex)
            {
                
                //MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sqlConn.Close();
            }
            return cod;

        }
        public void EliminarProfesor(string Codigo)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "EliminarProfesor";                
                sqlCom.Parameters.AddWithValue("@CODPROFESOR", Codigo);                
                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {

                    MessageBox.Show("Profesor Eliminado", "Eliminado");

                }
                sqlConn.Close();



            }
            catch (Exception)
            {

                MessageBox.Show("No se puede eliminar porque ya se esta usando en Cursos");

            }
            finally
            {
                sqlConn.Close();
            }


        }
    }
}
