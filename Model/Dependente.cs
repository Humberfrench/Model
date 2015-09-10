using System;

namespace Models
{
    public class Dependente : Basic
    {
        public DateTime DataNascimento { get; set; }
        public enumGrauParentesco GrauParentesco { get; set; }
    }
}