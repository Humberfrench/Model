using System.ComponentModel.DataAnnotations;

namespace Models
{
    [MetadataType(typeof(Empresa))]
    public class Empresa : Basic
    {
        [StringLength(20), Required]
        public string CNPJ { get; set; }

        [StringLength(50)]
        public string Site { get; set; }

        [StringLength(250), Required]
        public string Observacao { get; set; }
    }
}