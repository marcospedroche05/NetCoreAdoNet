using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SELECT DNOMBRE FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosDepartamentoAsync(string nombreDept)
        {
            string sql = "SELECT APELLIDO FROM EMP INNER JOIN DEPT ON EMP.DEPT_NO=DEPT.DEPT_NO WHERE DEPT.DNOMBRE=@dnombre";
            SqlParameter pamDept = new SqlParameter("@dnombre", nombreDept);
            this.com.Parameters.Add(pamDept);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            List<string> empleados = new List<string>();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task DeleteEmpleado(string apellido)
        {
            string sql = "DELETE FROM EMP WHERE APELLIDO=@apellido";
            SqlParameter pamApellido = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
        }
    }
}
