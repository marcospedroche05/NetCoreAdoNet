using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form10UpdateEmpleadosOficio : Form
    {
        RepositoryUpdateEmpleados repoUpdateEmpleados;
        public Form10UpdateEmpleadosOficio()
        {
            InitializeComponent();
            this.repoUpdateEmpleados = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async Task LoadOficios()
        {
            this.lstOficios.Items.Clear();
            List<string> oficios = await this.repoUpdateEmpleados.GetOficiosAsync();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private async Task LoadEmpleados(string oficio)
        {
            this.lstEmpleados.Items.Clear();
            List<string> empleados = await this.repoUpdateEmpleados.GetEmpleadosByOficioAsync(oficio);
            foreach (string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }

        private async void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int registros = await this.repoUpdateEmpleados.UpdateSalarioEmpleadosAsync(oficio, incremento);
            MessageBox.Show("Registros afectados: " + registros);
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            DatosEmpleados datosEmpleados = await this.repoUpdateEmpleados.GetDatosEmpleadosAsync(oficio);
            this.lblSuma.Text = datosEmpleados.SumaSalarial.ToString();
            this.lblMedia.Text = datosEmpleados.MediaSalarial.ToString();
            this.lblMaximo.Text = datosEmpleados.MaximoSalario.ToString();
            await this.LoadEmpleados(oficio);
        }
    }
}
