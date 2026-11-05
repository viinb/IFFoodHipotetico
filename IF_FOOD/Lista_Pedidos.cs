using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_Lista_Pedidos : Form
    {
        List<Produto> l_Prod;
        List<Pedido> l_Ped;

        public w_Lista_Pedidos(List<Produto> l_Produtos, List<Pedido> l_Pedidos) : this()
        {
            this.l_Prod = l_Produtos;
            this.l_Ped = l_Pedidos;
        }

        public w_Lista_Pedidos()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Pedido P = new Pedido();
            w_Det_Pedido w_Det = new w_Det_Pedido(P, l_Prod);
            w_Det.ShowDialog();

            if (P.Qtde_Total != 0) //Cadastrou!!!
            {
                this.l_Ped.Add(P);
            }
        }

        private void w_Lista_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            List<string> Lista = new List<string>();

            foreach (Pedido Ped in this.l_Ped)
            {
                Lista.Add("Cód: " + Ped.Codigo + " Qtde.:" + Ped.Qtde_Total + " Valor Total: " + Ped.Valor_Total);
                foreach (Item_Pedido Item in Ped.Lista_Itens)
                {
                    Lista.Add("     Cód Prod: " + Item.Prod.Codigo + " Qtde.:" + Item.Qtde + " Valor: " + Item.Valor());
                }
                Lista.Add(" ");
            }

            w_Imp_Lista w_Imp = new w_Imp_Lista(Lista, "Pedidos");
            w_Imp.ShowDialog();
        }
    }
}
