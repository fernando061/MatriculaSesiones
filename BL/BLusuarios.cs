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
    public class BLusuarios
    {
        public void buscarUsuarioText(ref DataTable dt, string buscador)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {

                    sqlConn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("buscarUsrText", sqlConn);

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                    da.Fill(dt);
                    sqlConn.Close();

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
        public void InsertUsuarios(BEusuario bEusuario)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("insertUsuario", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombres", bEusuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", bEusuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", bEusuario.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", bEusuario.Contraseña);
                    cmd.Parameters.AddWithValue("@Id_cargo", bEusuario.Id_cargo);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Usuario Registrado");
                    }

                    sqlConn.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
                
            

        }
        public void UpdateUsuario(BEusuario bEusuario)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("UpdateUsuario", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", bEusuario.ID);
                    cmd.Parameters.AddWithValue("@Nombres", bEusuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", bEusuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", bEusuario.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", bEusuario.Contraseña);
                    cmd.Parameters.AddWithValue("@Estado", bEusuario.Estado);
                    cmd.Parameters.AddWithValue("@Id_cargo", bEusuario.Id_cargo);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Usuario Actualizado");
                    }
                    sqlConn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.StackTrace);
                }
                
            }
                


        }
        public void DeletUsuario(int Id)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("DeletUsuario", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Usuario Eliminado");
                    }
                    sqlConn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.StackTrace);
                }  
            }
        }
        public void CargosCmb(ref DataTable dt)
        {


            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {

                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT *
FROM Cargos", sqlConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);



                    DataRow fila = dt.NewRow();
                    fila["Cargo"] = "Seleccionar";
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
        }

    }
}
