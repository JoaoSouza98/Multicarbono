namespace prjMultiCarbono.Entities
{
    public class ItemPedido : Entity
    {
        public int Quantidade { get; set; }
        public float ValorDesconto { get; set; }

        public Produto Produto { get; set; }
        public int IdProduto { get; set; }

        public Pedido Pedido { get; set; }
        public int IdPedido { get; set; }


    }
}
