using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DB;

namespace BL
{
    public class BLlogin
    {
		public Boolean Login(string user,string pass)
		{

			
			using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
			{
				sqlConn.Open();
				SqlCommand sqlCom = sqlConn.CreateCommand();
				sqlCom.CommandType = CommandType.StoredProcedure;
				sqlCom.CommandText = "LoginSanM";
				sqlCom.Parameters.AddWithValue("@user", user);
				sqlCom.Parameters.AddWithValue("@pass", pass);

				SqlDataReader sqlDR = sqlCom.ExecuteReader();

				if (sqlDR.Read())
				{
					sqlConn.Close();
					return true;
				}
				else
				{
					sqlConn.Close();
					return false;
				}
				

			}



		}


		public int IdUsuario(string user, string pass)
		{
			int id = 0;

			using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
			{
				sqlConn.Open();
				SqlCommand sqlCom = sqlConn.CreateCommand();
				sqlCom.CommandType = CommandType.StoredProcedure;
				sqlCom.CommandText = "LoginSanM";
				sqlCom.Parameters.AddWithValue("@user", user);
				sqlCom.Parameters.AddWithValue("@pass", pass);

				SqlDataReader sqlDR = sqlCom.ExecuteReader();

				if (sqlDR.Read())
				{
					id =Convert.ToInt32(sqlDR[6]);
					
				}
				return id;


			}



		}
	}
}
