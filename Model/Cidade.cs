namespace Models
{
    class Cidade 
    {
        public int Codigo{ get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome.ToString();
        }
        public Estado UF { get; set; }
    }
}
