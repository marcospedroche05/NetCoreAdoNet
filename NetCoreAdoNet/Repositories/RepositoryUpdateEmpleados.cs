using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NetCoreAdoNet.Models;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "SELECT DISTINCT OFICIO FROM EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            List<string> oficios = new List<string>();
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "SELECT APELLIDO FROM EMP WHERE OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> empleados = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                empleados.Add(ape);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            string sql = "UPDATE EMP SET SALARIO=SALARIO + @incremento where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<DatosEmpleados> GetDatosEmpleadosAsync(string oficio)
        {
            string sql = "SELECT SUM(SALARIO) AS 'SUMA_SALARIAL', AVG(SALARIO) AS 'MEDIA', MAX(SALARIO) AS 'MAXIMO' FROM EMP WHERE OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleados datos = new DatosEmpleados();
            while(await this.reader.ReadAsync())
            {
                string media = this.reader["MEDIA"].ToString();
                string sumaSalarial = this.reader["SUMA_SALARIAL"].ToString();
                string maximo = this.reader["MAXIMO"].ToString();
                datos.MediaSalarial = int.Parse(media);
                datos.SumaSalarial = int.Parse(sumaSalarial);
                datos.MaximoSalario = int.Parse(maximo);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}
