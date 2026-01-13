using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet
{
    public partial class Form02BuscadorEmpleado : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
        public Form02BuscadorEmpleado()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //CONSULTA SQL
            string sql = "select * from EMP where SALARIO >= " + this.txtSalario.Text;
            //CONFIGURAMOS EL COMMANDER
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ENTRAR Y SALIR 
            //ABRIMOS CONEXION
            this.cn.Open();
            //EJECUTAMOS LA CONSULTA
            this.reader = this.com.ExecuteReader();
            //DIBUJAMOS LOS DATOS
            this.lstEmpleado.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstEmpleado.Items.Add(apellido + " - " + salario);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
