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