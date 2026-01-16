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
    public partial class Form09CRUDHospital : Form
    {
        RepositoryHospitales repoHospitales;
        public Form09CRUDHospital()
        {
            InitializeComponent();
            this.repoHospitales = new RepositoryHospitales();
            this.LoadHospitales();

        }

        private async Task LoadHospitales()
        {
            this.lstHospitales.Items.Clear();
            List<Hospital> hospitales = await this.repoHospitales.GetHospitalesAsync();
            foreach (Hospital hospital in hospitales)
            {
                this.lstHospitales.Items.Add(hospital.Hospital_cod + " @ " + hospital.Nombre + " @ " + hospital.Direccion + " @ " + hospital.Telefono + " @ " + hospital.Camas);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repoHospitales.CreateHospitalAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repoHospitales.DeleteHospitalAsync(id);
            await this.LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repoHospitales.UpdateHospitalAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtId.Text = this.lstHospitales.SelectedItem.ToString().Split('@')[0].Trim();
            this.txtNombre.Text = this.lstHospitales.SelectedItem.ToString().Split('@')[1].Trim();
            this.txtDireccion.Text = this.lstHospitales.SelectedItem.ToString().Split('@')[2].Trim();
            this.txtTelefono.Text = this.lstHospitales.SelectedItem.ToString().Split('@')[3].Trim();
            this.txtCamas.Text = this.lstHospitales.SelectedItem.ToString().Split('@')[4].Trim();
        }
    }
}
