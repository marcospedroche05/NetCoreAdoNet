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
    public partial class Form3EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form3EliminarEnfermo()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadEnfermos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS EL DATO DE INSCRIPCION CONCATENADO
            string inscripcion = this.txtInscripcion.Text;
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION = " + inscripcion;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //LAS CONSULTAS DE ACCION DEVUELVEN UN INT CON EL NUMERO DE REGISTROS AFECTADOS
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.LoadEnfermos();
            MessageBox.Show("Enfermos eliminados: " + registros);
        }

        private void LoadEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
