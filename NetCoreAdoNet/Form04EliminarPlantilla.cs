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
            string sql = "DELETE FROM PLANTILLA WHERE EMPLEADO_NO = " + this.txtId.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
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
