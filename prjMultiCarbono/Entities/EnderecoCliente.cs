namespace prjMultiCarbono.Entities
{
    public class EnderecoCliente : Entity
    {
        public int TipoEndereco { get; set; }
        public Endereco Endereco { get; set; }
        public int IdEndereco { get; set; }

        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
    }
}
