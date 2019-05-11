namespace prjMultiCarbono.Entities
{
    public class ItemNota : Entity
    {
        public int Quantidade { get; set; }
        public string ValorDesconto { get; set; }
        public int Cfop { get; set; }

        public Produto Produto { get; set; }
        public int IdProduto { get; set; }

        public NotaFiscal NotaFiscal { get; set; }
        public int IdNotaFiscal { get; set; }
    }
}
