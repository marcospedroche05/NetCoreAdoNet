using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaMartes.Models
{
    public class EmpleadosHospitalModel
    {
        public string Apellido { get; set; }
        public string Campo { get; set; }
        public int Salario { get; set; }

        public EmpleadosHospitalModel(string apellido, string campo, int salario) {
            this.Apellido = apellido;
            this.Campo = campo;
            this.Salario = salario;
        }
    }
}
