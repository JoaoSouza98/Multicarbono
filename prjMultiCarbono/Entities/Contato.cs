namespace prjMultiCarbono.Entities
{
    public class Contato : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public Cliente Cliente { get; set; }
        public int IdContato { get; set; }
    }
}
