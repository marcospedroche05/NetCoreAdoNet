using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadPlantilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int empleado_no = int.Parse(this.txtId.Text);
            string sql = "DELETE FROM PLANTILLA WHERE EMPLEADO_NO = @empleado_no";
            SqlParameter pamEmp = new SqlParameter("@empleado_no", empleado_no);
            //NOMBRE DEL PARAMETRO EN LA CONSULTA, NO PUEDE ESTAR REPETIDO
            //pamEmp.ParameterName = "@empleado_no";
            //pamEmp.DbType = DbType.Int32;
            //POR DEFECTO LA DIRECCION ES INPUT
            //pamEmp.Direction = ParameterDirection.Input;
            //EL VALOR DEL PARAMETRO PARA SUSTITUIR EN LA CONSULTA
            //pamEmp.Value = empleado_no;
            //AGREGAMOS EL PARAMETRO A LA COLECCION
            this.com.Parameters.Add(pamEmp);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //LIBERAMOS LOS PARAMETROS DE LA CONEXION
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.txtId.Clear();
            this.LoadPlantilla();
        }

        private void LoadPlantilla()
        {
            string sql = "SELECT * FROM PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string emp_no = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstPlantilla.Items.Add(emp_no + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstPlantilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtId.Text = lstPlantilla.SelectedItem.ToString().Split('-')[0].Trim();
        }
    }
}
