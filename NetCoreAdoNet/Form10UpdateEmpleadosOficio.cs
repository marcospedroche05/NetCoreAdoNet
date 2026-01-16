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
            string resultados = await this.repoUpdateEmpleados.GetInfoSalarialAsync(oficio);
            string suma = resultados.Split('-')[0].Trim();
            string media = resultados.Split('-')[1].Trim();
            string maximo = resultados.Split('-')[2].Trim();
            this.lblSuma.Text = suma;
            this.lblMedia.Text = media;
            this.lblMaximo.Text = maximo;
            await this.LoadEmpleados(oficio);
        }
    }
}
