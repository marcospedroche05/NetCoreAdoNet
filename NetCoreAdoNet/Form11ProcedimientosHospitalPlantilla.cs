using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
//CREATE PROCEDURE SP_ALL_HOSPITALES
//AS
//	SELECT * FROM HOSPITAL
//GO

//CREATE PROCEDURE SP_UPDATE_PLANTILLA_HOSPITAL
//(@nombre NVARCHAR(50), @incremento int)
//AS
//	DECLARE @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD FROM HOSPITAL
//	WHERE NOMBRE = @nombre
//	UPDATE PLANTILLA SET SALARIO = SALARIO + @incremento
//	WHERE HOSPITAL_COD = @hospitalcod
//GO

//CREATE PROCEDURE SP_PLANTILLA_HOSPITAL
//(@nombre NVARCHAR(50))
//AS
//	SELECT PLANTILLA.* FROM PLANTILLA 
//	INNER JOIN HOSPITAL 
//	ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//	WHERE HOSPITAL.NOMBRE = @nombre
//GO
#endregion

namespace NetCoreAdoNet
{
    public partial class Form11ProcedimientosHospitalPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form11ProcedimientosHospitalPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();
        }

        private async void btnModificarSalario_Click(object sender, EventArgs e)
        {
            string sql = "SP_UPDATE_PLANTILLA_HOSPITAL";
            string nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            await this.LoadPlantilla(nombreHospital);

            MessageBox.Show("Registros modificados: " + registros);
        }

        private async Task LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbHospitales.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async Task LoadPlantilla(string nombreHospital)
        {
            string sql = "SP_PLANTILLA_HOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
