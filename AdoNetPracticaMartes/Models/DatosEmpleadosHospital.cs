using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaMartes.Models
{
    public class DatosEmpleadosHospital
    {
        public List<EmpleadosHospitalModel> EmpleadosHospital { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }

        public DatosEmpleadosHospital()
        {
            this.EmpleadosHospital = new List<EmpleadosHospitalModel>();
        }
    }
}
