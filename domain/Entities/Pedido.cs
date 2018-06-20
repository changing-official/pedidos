using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public string Cliente { get; set; }
        public IList<ItemPedido> Itens { get; set; }
    }
}
