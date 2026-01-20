using AdoNetPracticaMartes.Helpers;
using AdoNetPracticaMartes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

#region STORED PROCEDURES
//------ TODOS LOS HOSPITALES -------

//CREATE PROCEDURE SP_ALL_HOSPITALES_MARTES
//AS
//	SELECT NOMBRE FROM HOSPITAL
//GO

//-------------------------------------

//------------ TODOS LOS EMPLEADOS DEL HOSPITAL ------

//ALTER PROCEDURE SP_EMPLEADOS_HOSPITAL_MARTES
//(@nombre NVARCHAR(50), @suma int OUT, @media int OUT, @personas int OUT)
//AS 
//	DECLARE @idHospital int;
//SELECT @idHospital = HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE=@nombre;
//PRINT @idHospital;

//SELECT* FROM VISTA_EMPLEADOS_HOSPITAL WHERE HOSPITAL_COD = @idHospital;

//SELECT @suma = ISNULL(SUM(SALARIO), 0), @media = ISNULL(AVG(SALARIO), 0), @personas = COUNT(*)
//	FROM VISTA_EMPLEADOS_HOSPITAL WHERE HOSPITAL_COD = @idHospital;

//PRINT @suma;
//PRINT @media;
//PRINT @personas
//GO

//----------------------------------------------------


#endregion

namespace AdoNetPracticaMartes.Repositories
{ 
    public class RepositoryMartes
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryMartes()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetHospitalesAsync()
        {
            string sql = "SP_ALL_HOSPITALES_MARTES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            List<string> hospitales = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task<DatosEmpleadosHospital> GetDatosEmpleadosModel(string nombreHospital)
        {
            string sql = "SP_EMPLEADOS_HOSPITAL_MARTES";
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);

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
            DatosEmpleadosHospital datosEmpleados = new DatosEmpleadosHospital();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string campo = this.reader["CAMPO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                EmpleadosHospitalModel empleado = new EmpleadosHospitalModel(apellido, campo, salario);
                datosEmpleados.EmpleadosHospital.Add(empleado);
            }
            await this.reader.CloseAsync();
            datosEmpleados.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            datosEmpleados.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            datosEmpleados.Personas = int.Parse(pamPersonas.Value.ToString());
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return datosEmpleados;
        }
    }
}
