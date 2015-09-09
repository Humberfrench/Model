using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [MetadataType(typeof(Basic))]
    public class Basic
    {

        public int Codigo { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public Empresa Empresa { get; set; }


        public  override string ToString()
        {
            return Nome.ToString();
        }
    }
}
