using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametersOut repo;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach(string dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept);
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut datosEmpleados = await this.repo.GetEmpleadosModelAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (string empleado in datosEmpleados.Apellidos)
            {
                this.lstEmpleados.Items.Add(empleado);
            }
            this.txtSumasalarial.Text = datosEmpleados.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = datosEmpleados.MediaSalarial.ToString();
            this.txtPersonas.Text = datosEmpleados.Personas.ToString();
        }
    }
}
