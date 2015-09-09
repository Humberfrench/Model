using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario :Basic
    {

        #region "constructor"
        public Funcionario()
        {
            blnTemDependentes = false;
            Dependentes = new List<Dependente>();
            Documentos = new List<Documento>();
        }
        #endregion

        #region "local variables"
        bool blnTemDependentes;
        #endregion

        #region "properties"
        public GradeCargo Cargo { get; set; }
        public enumEstadoCivil EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
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
        public List<Documento> Documentos { get; set; }
        #endregion
  
    }
}
