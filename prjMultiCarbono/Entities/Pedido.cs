using System.Collections.Generic;

namespace prjMultiCarbono.Entities
{
    public class Pedido : Entity
    {
        public int numPedido { get; set; }
        public string DtEmissao { get; set; }
        public string DtCarregamento { get; set; }
        public string DtAnalise { get; set; }
        public string Observacao { get; set; }
        public string TipoFrete { get; set; }

        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }

        public List<ItemPedido> ListaItemPedido { get; set; }
        public List<int> ListaIdItemPedido { get; set; }

    }
}
