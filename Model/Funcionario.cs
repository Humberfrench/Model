using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario :Basic
    {
        
        public Funcionario()
        {
            blnTemDependentes = false;
            Dependentes = new List<Dependente>();
        }

        bool blnTemDependentes;
        public GradeCargo Cargo  { get; set; }

        public List<Dependente> Dependentes { get; set; }
        public bool TemDependentes 
        { 
            get 
            {
                if (QtdeDependentes == 0)
                {
                    blnTemDependentes = false;
                }
                else
                {
                    blnTemDependentes = true;
                }

                return blnTemDependentes;
            }
        }
        public int QtdeDependentes 
        {
            get 
            {
                return Dependentes.Count;
            }
        }   
    }
}
