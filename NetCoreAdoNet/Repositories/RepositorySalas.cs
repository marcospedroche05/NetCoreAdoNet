using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositorySalas
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> getNombresSalas()
        {
            string sql = "SELECT DISTINCT NOMBRE FROM SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS LA COLECCION A DEVOLVER
            List<string> nombresSalas = new List<string>();
            while (this.reader.Read())
            {
                nombresSalas.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return nombresSalas;
        }

        public void UpdateNombreSala(string newName, string oldName)
        {
            string sql = "UPDATE SALA SET NOMBRE=@newname WHERE NOMBRE=@oldname";
            SqlParameter pamNew = new SqlParameter("@newname", newName);
            SqlParameter pamOld = new SqlParameter("@oldname", oldName);
            this.com.Parameters.Add(pamNew);
            this.com.Parameters.Add(pamOld);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
        }
    }
}
