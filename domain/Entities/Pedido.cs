using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            Itens = new List<Item>();
        }

        public string Cliente { get; set; }
        public IList<Item> Itens { get; set; }
    }
}
