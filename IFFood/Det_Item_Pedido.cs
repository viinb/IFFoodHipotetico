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
    public partial class w_Det_Item_Pedido : Form
    {
        List<Item_Pedido> Lista_Itens;
        Produto Prod;

        public w_Det_Item_Pedido()
        {
            InitializeComponent();
        }
        public w_Det_Item_Pedido(List<Item_Pedido> Lista, Produto P) : this()
        {
            this.Lista_Itens = Lista;
            this.Prod = P;
        }


        private void w_Det_Item_Pedido_Load(object sender, EventArgs e)
        {
            tb_Codigo.Text = this.Prod.Codigo;
            tb_Descricao.Text = this.Prod.Desc;
            tb_Qtde.Text = "0";
            tb_Valor.Text = "0";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tb_Qtde.Text) <= Prod.Qtde)
            {
                this.Lista_Itens.Add(new Item_Pedido());
                this.Lista_Itens[this.Lista_Itens.Count-1].Prod = Prod;
                this.Lista_Itens[this.Lista_Itens.Count-1].Qtde = Int32.Parse(tb_Qtde.Text);
                Prod.Qtde -= this.Lista_Itens[this.Lista_Itens.Count-1].Qtde;

                this.Close();
            }
            else
            {
                MessageBox.Show("Quantidade insuficiente no estoque!!");
            }

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Qtde_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_Qtde.Text != "0" && this.tb_Qtde.Text.Trim() != "")
            {
                tb_Valor.Text = (Prod.Preco * Int32.Parse(tb_Qtde.Text)).ToString();
            }
        }
    }
}
