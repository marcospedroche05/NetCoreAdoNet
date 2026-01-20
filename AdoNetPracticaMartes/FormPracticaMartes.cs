using AdoNetPracticaMartes.Models;
using AdoNetPracticaMartes.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdoNetPracticaMartes
{
    public partial class FormPracticaMartes : Form
    {
        RepositoryMartes repo;
        public FormPracticaMartes()
        {
            InitializeComponent();
            this.repo = new RepositoryMartes();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<string> hospitales = await this.repo.GetHospitalesAsync();
            this.cmbHospitales.Items.Clear();
            foreach(string nombre in hospitales)
            {
                this.cmbHospitales.Items.Add(nombre);
            }
            
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string hospital = this.cmbHospitales.SelectedItem.ToString();
            DatosEmpleadosHospital datosEmpleados = await this.repo.GetDatosEmpleadosModel(hospital);
            this.lstEmpleadosHospital.Items.Clear();
            foreach(EmpleadosHospitalModel empleado in datosEmpleados.EmpleadosHospital)
            {
                this.lstEmpleadosHospital.Items.Add(empleado.Apellido + " - " + empleado.Campo + " - " + empleado.Salario);
            }
            this.txtSumaSalarial.Text = datosEmpleados.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = datosEmpleados.MediaSalarial.ToString();
            this.txtPersonas.Text = datosEmpleados.Personas.ToString();
        }
    }
}
