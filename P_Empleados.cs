using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador
{
    public class P_Empleados
    {
        public int Id { get; set; }
        public string Run { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Direccion { get; set; }
        public int Telefono { get; set; }
        public int Valor_Trabajadas { get; set; }
        public int Valor_Extra { get; set; }
        public int Sueldo_Bruto { get; set; }
        public int Sueldo_Liquido { get; set; }
        public string Fecha_Creacion { get; set; }
        public string Fecha_Modificacion { get; set; }

    }
}
