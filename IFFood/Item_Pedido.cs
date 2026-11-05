using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Item_Pedido
    {
        public Produto Prod { get; set; }

        public int Qtde;

        public double Valor()
        {
            return this.Prod.Preco * this.Qtde;
        }
    }
}
