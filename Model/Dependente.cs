using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dependente : Basic
    {

        public DateTime DataNascimento { get; set; }
        public enumGrauParentesco GrauParentesco { get; set; }

    }
}
