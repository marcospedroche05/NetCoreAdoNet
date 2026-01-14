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
    public partial class Form06UpdateNombreSala : Form
    {
        RepositorySalas repoSalas;
        public Form06UpdateNombreSala()
        {
            InitializeComponent();
            this.repoSalas = new RepositorySalas();
            this.LoadSalas();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNombre.Text;
            await this.repoSalas.UpdateNombreSalaAsync(newName, oldName);
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            List<string> nombresSalas = await this.repoSalas.GetNombresSalasAsync();
            this.lstSalas.Items.Clear();
            foreach(string nombre in nombresSalas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }
    }
}
