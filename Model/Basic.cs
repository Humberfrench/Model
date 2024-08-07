using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Basic
    {
        public int Codigo { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public Empresa Empresa { get; set; }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}