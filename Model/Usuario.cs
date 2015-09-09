using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Usuario : Basic
    {
        [StringLength(15)]
        public string Login { get; set; }
        
        [StringLength(15)]
        public string Senha { get; set; }

    }
}
