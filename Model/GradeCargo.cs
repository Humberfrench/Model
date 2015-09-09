using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GradeCargo
    {

        public Cargo Cargo  { get; set; }
        public Nivel Nivel { get; set; }
        public double Salario { get; set; }
        public enumTipoSalario TipoSalario { get; set; }

    }
}
