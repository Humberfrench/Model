namespace Models
{
    public class GradeCargo
    {
        public Cargo Cargo { get; set; }
        public Nivel Nivel { get; set; }
        public double Salario { get; set; }
        public enumTipoSalario TipoSalario { get; set; }
    }
}