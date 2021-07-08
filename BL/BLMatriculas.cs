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
    public class BLMatriculas
    {

        public void InsertMatricula(BEmatricula bEmatricula)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand("insertMatricula", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", bEmatricula.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", bEmatricula.Apellido);
                    cmd.Parameters.AddWithValue("@Num_doc", bEmatricula.NumDoc);
                    cmd.Parameters.AddWithValue("@Correo", bEmatricula.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", bEmatricula.Telefono);
                    cmd.Parameters.AddWithValue("@Fecha_deposito", bEmatricula.Fecha_deposito);
                    cmd.Parameters.AddWithValue("@Monto", bEmatricula.Monto);
                    cmd.Parameters.AddWithValue("@Banco_deposito", bEmatricula.Banco_deposito);
                    cmd.Parameters.AddWithValue("@Numero_operacion", bEmatricula.Numero_operacion);
                    cmd.Parameters.AddWithValue("@Id_curso", bEmatricula.Id_curso);
                    cmd.Parameters.AddWithValue("@baucher", bEmatricula.File);
                    cmd.Parameters.AddWithValue("@extencion", bEmatricula.Extencion);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Matricula Registrada");
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            

            
            

        }
        public void buscarMatriculaText(ref DataTable dt, string buscador)
        {


            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());

            try
            {

                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("buscarMatriculaText", sqlConn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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
        public void UpdateMatricula(BEmatricula bEmatricula)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "UpdateMatricula";
                sqlCom.Parameters.AddWithValue("@CODMATRICULA", bEmatricula.Id_matricula);
                sqlCom.Parameters.AddWithValue("@Nombre", bEmatricula.Nombre);
                sqlCom.Parameters.AddWithValue("@Apellido", bEmatricula.Apellido);
                sqlCom.Parameters.AddWithValue("@Num_doc", bEmatricula.NumDoc);
                sqlCom.Parameters.AddWithValue("@Correo", bEmatricula.Correo);
                sqlCom.Parameters.AddWithValue("@Telefono", bEmatricula.Telefono);
                sqlCom.Parameters.AddWithValue("@Fecha_deposito", bEmatricula.Fecha_deposito);
                sqlCom.Parameters.AddWithValue("@Monto", bEmatricula.Monto);
                sqlCom.Parameters.AddWithValue("@Banco_deposito", bEmatricula.Banco_deposito);
                sqlCom.Parameters.AddWithValue("@Numero_operacion", bEmatricula.Numero_operacion);
                sqlCom.Parameters.AddWithValue("@Estado", bEmatricula.Estado);
                sqlCom.Parameters.AddWithValue("@Id_curso", bEmatricula.Id_curso);

                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("Matricula Actualizada");

                }




            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConn.Close();
            }

        }
        public void DeletMatricula(string ID)
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                try
                {
                    sqlConn.Open();

                    SqlCommand sqlComm = sqlConn.CreateCommand();

                    sqlComm.CommandText = "update Matricula set Estado='Eliminado' where CODMATRICULA=@ID";


                    sqlComm.Parameters.AddWithValue("@ID", ID);


                    int rows = sqlComm.ExecuteNonQuery();
                    sqlConn.Close();

                    if (rows != 1)
                    {
                        MessageBox.Show("Error UPDATE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Longitud de letras muy amplia","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    sqlConn.Close();                    
                }

            
                
            }
        }
        public int getIdMatricula(string idMatricula)
        {
            int proId = 0;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
                {
                    sqlConn.Open();
                    SqlCommand sqlCom = sqlConn.CreateCommand();
                    sqlCom.CommandType = CommandType.Text;

                    sqlCom.CommandText = @"select Id_matricula from Matricula where CODMATRICULA=@CODIGO";
                    sqlCom.Parameters.AddWithValue("@CODIGO", idMatricula);
                    SqlDataReader sqlDR = sqlCom.ExecuteReader();
                    if (sqlDR.Read())
                    {
                        proId = Convert.ToInt32(sqlDR[0]);
                    }



                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

            return proId;

        }
        public static object Costo(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;


        }
     
        public BEprueba finFile(int id)
        {
            BEprueba bEprueba = null;
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConn.Open();

                SqlCommand sqlCom = sqlConn.CreateCommand();

                sqlCom.CommandText = "select baucher,extencion from Matricula where Id_matricula=@id";
                sqlCom.Parameters.AddWithValue("@id", id);


                SqlDataReader sqlDR = sqlCom.ExecuteReader();


                if (sqlDR.Read())
                {
                    bEprueba = new BEprueba();
                    bEprueba.file = (byte[])sqlDR[0];
                    bEprueba.exten = sqlDR.GetString(1);

                }

                
            }


            return bEprueba;
        }
        public void UpdateFile(int Id,byte [] file,string Extencion)
        {

            SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer());
            try
            {

                sqlConn.Open();
                SqlCommand sqlCom = sqlConn.CreateCommand();
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "UpdateFile";
                sqlCom.Parameters.AddWithValue("@id", Id);
                sqlCom.Parameters.AddWithValue("@File", file);
                sqlCom.Parameters.AddWithValue("@Extencion", Extencion);              
                int rows = sqlCom.ExecuteNonQuery();

                if (rows == 1)
                {
                    MessageBox.Show("Archivo Actualizado");

                }




            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConn.Close();
            }

        }
    }
}
