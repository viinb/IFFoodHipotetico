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
    public partial class w_Add_Itens : Form
    {
        Pedido Ped;
        List<Produto> l_Prod;
        w_Det_Pedido w_Det_Ped;

        public w_Add_Itens(Pedido Ped, List<Produto> L, w_Det_Pedido Det) : this()
        {
            this.Ped = Ped;
            this.l_Prod = L;
            this.w_Det_Ped = Det;
        }

        public w_Add_Itens()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Atualizar()
        {
            lb_Lista.Items.Clear();
            foreach (Produto P in this.l_Prod)
            {
                lb_Lista.Items.Add("Cód: " + P.Codigo + " Descr.:" + P.Desc + " Qtde.:" + P.Qtde + " Preço: " + P.Preco);
            }
        }
        private void Add_Itens_Load(object sender, EventArgs e)
        {

            this.Atualizar();
        }

        private void lb_Lista_DoubleClick(object sender, EventArgs e)
        {
            w_Det_Item_Pedido w_Det;

            if (lb_Lista.SelectedIndex >= 0)
            {
                w_Det = new w_Det_Item_Pedido(Ped.Lista_Itens, l_Prod[lb_Lista.SelectedIndex]);
                w_Det.ShowDialog();
                this.Atualizar();
                this.w_Det_Ped.Atualizar();
            }
        }

        private void lb_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
