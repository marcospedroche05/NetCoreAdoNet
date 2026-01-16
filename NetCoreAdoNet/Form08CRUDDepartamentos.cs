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
    public partial class Form08CRUDDepartamentos : Form
    {
        RepositoryDepartamentos repoDept;
        public Form08CRUDDepartamentos()
        {
            InitializeComponent();
            this.repoDept = new RepositoryDepartamentos();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.repoDept.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept.Dept_no + " - " + dept.Nombre + " - " + dept.Localidad);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repoDept.CreateDepartamentoAsync(numero, nombre, localidad);
            await this.LoadDepartamentos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repoDept.UpdateDepartamentoAsync(numero, nombre, localidad);
            await this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await repoDept.DeleteDepartamentoAsync(id);
            await this.LoadDepartamentos();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtId.Text = this.lstDepartamentos.SelectedItem.ToString().Split('-')[0].Trim();
            this.txtNombre.Text = this.lstDepartamentos.SelectedItem.ToString().Split('-')[1].Trim();
            this.txtLocalidad.Text = this.lstDepartamentos.SelectedItem.ToString().Split('-')[2].Trim();
        }
    }
}
