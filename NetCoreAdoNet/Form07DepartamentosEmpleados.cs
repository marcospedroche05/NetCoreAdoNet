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
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repoDeptEmp;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repoDeptEmp = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDept = this.lstDepartamentos.SelectedItem.ToString();
            this.LoadEmpleados(nombreDept);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            string nombreDept = this.lstDepartamentos.SelectedItem.ToString();
            await this.repoDeptEmp.DeleteEmpleado(empleado);
            this.LoadEmpleados(nombreDept);
        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos = await this.repoDeptEmp.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string dept in departamentos)
            {
                string nombre = dept;
                this.lstDepartamentos.Items.Add(nombre);
            }
        }

        private async void LoadEmpleados(string nombreDept)
        {

            List<string> empleados = await this.repoDeptEmp.GetEmpleadosDepartamentoAsync(nombreDept);
            this.lstEmpleados.Items.Clear();
            foreach(string emp in empleados)
            {
                string apellido = emp;
                this.lstEmpleados.Items.Add(apellido);
            }
        }
    }
}
