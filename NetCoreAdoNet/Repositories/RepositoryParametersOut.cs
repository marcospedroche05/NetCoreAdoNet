using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text;


#region PROCEDIMIENTOS ALMACENADOS
//ALTER PROCEDURE SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre NVARCHAR(50), @suma int OUT, @media int OUT, @personas int OUT)
//AS

//	DECLARE @iddept int
//	SELECT @iddept = DEPT_NO FROM DEPT WHERE DNOMBRE=@nombre
//	--LA CONSULTA DEL PROCEDIMIENTO
//	SELECT * FROM EMP WHERE DEPT_NO=@iddept

//	SELECT @suma = isnull(SUM(SALARIO), 0), @media = isnull(AVG(SALARIO), 0), @personas = COUNT(EMP_NO) FROM EMP WHERE DEPT_NO = @iddept
//GO
#endregion



namespace NetCoreAdoNet.Repositories
{
    public class RepositoryParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametersOut()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync() {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<EmpleadosParametersOut> GetEmpleadosModelAsync(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //TENEMOS UN PARAMETRO DE ENTRADA, POR DEFECTO, TODOS
            //SON DE ENTRADA, PODEMOS SEGUIR UTILIZANDO AddWithValue
            //CON DICHO PARAMETRO
            string nombre = nombreDepartamento;
            this.com.Parameters.AddWithValue("@nombre", nombre);
            //LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLICITA
            //SqlParameter pamNombre = new SqlParameter();
            //pamNombre.ParameterName = "@nombre";
            //pamNombre.Value = nombre;
            //this.com.Parameters.Add(pamNombre);
            //EN ESTE EJEMPLO, NO HEMOS PUESTO VALORES POR DEFECTO A LOS PARAMETROS
            //POR LO QUE SON OBLIGATORIOS
            SqlParameter pamSuma = new SqlParameter();
            SqlParameter pamMedia = new SqlParameter();
            SqlParameter pamPersonas = new SqlParameter();

            pamSuma.ParameterName = "@suma";
            pamSuma.Direction = ParameterDirection.Output;
            pamSuma.Value = 0;
            this.com.Parameters.Add(pamSuma);

            pamMedia.ParameterName = "@media";
            pamMedia.Direction = ParameterDirection.Output;
            pamMedia.Value = 0;
            this.com.Parameters.Add(pamMedia);

            pamPersonas.ParameterName = "@personas";
            pamPersonas.Direction = ParameterDirection.Output;
            pamPersonas.Value = 0;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            EmpleadosParametersOut model = new EmpleadosParametersOut();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                model.Apellidos.Add(apellido);
            }

            //LIBERAMOS LOS RECURSOS DE LA CONEXION Y DEMAS
            await this.reader.CloseAsync();
            //DIBUJAMOS LOS PARAMETROS
            model.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.Personas = int.Parse(pamPersonas.Value.ToString());
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return model;
        }
    }
}
