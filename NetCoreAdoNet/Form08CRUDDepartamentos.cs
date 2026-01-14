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
    }
}
