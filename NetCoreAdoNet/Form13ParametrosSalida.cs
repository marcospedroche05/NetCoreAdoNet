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
//CREATE PROCEDURE SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre NVARCHAR(50), @suma int OUT, @media int OUT, @personas int OUT)
//AS
//	DECLARE @iddept int
//	SELECT @iddept = DEPT_NO FROM DEPT WHERE DNOMBRE=@nombre
//	--LA CONSULTA DEL PROCEDIMIENTO
//	SELECT * FROM EMP WHERE DEPT_NO=@iddept
	
//	SELECT @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) FROM EMP WHERE DEPT_NO = @iddept
//GO
#endregion

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //TENEMOS UN PARAMETRO DE ENTRADA, POR DEFECTO, TODOS
            //SON DE ENTRADA, PODEMOS SEGUIR UTILIZANDO AddWithValue
            //CON DICHO PARAMETRO
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
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
            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            
            //LIBERAMOS LOS RECURSOS DE LA CONEXION Y DEMAS
            await this.reader.CloseAsync();
            //DIBUJAMOS LOS PARAMETROS
            this.txtSumasalarial.Text = pamSuma.Value.ToString();
            this.txtMediaSalarial.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();


        }
    }
}
