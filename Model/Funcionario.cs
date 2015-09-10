using System;
using System.Collections.Generic;

namespace Models
{
    public class Funcionario : Basic
    {
        #region "constructor"

        public Funcionario()
        {
            blnTemDependentes = false;
            Dependentes = new List<Dependente>();
            Documentos = new List<Documento>();
        }

        #endregion "constructor"

        #region "local variables"

        private bool blnTemDependentes;

        #endregion "local variables"

        #region "properties"

        public string NomeSocial { get; set; }
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

        #endregion "properties"
    }
}