﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Estado
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
