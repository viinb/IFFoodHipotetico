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
    public partial class w_Det_Pedido : Form
    {
        Pedido Ped;
        List<Produto> l_Prod;        

        public w_Det_Pedido(Pedido P, List<Produto> l_Produtos) : this()
        {
            this.Ped = P;
            this.l_Prod = l_Produtos;            
        }

        public w_Det_Pedido()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Ped.Qtde_Total = Int32.Parse(tb_Qtde.Text);
            this.Ped.Valor_Total = Double.Parse(tb_Valor.Text);

            this.Close();
        }

        private void Det_Pedido_Load(object sender, EventArgs e)
        {            
            tb_Codigo.Text = this.Ped.Codigo;            
            tb_Qtde.Text = this.Ped.Qtde_Total.ToString();
            tb_Valor.Text = this.Ped.Valor_Total.ToString();
        }

        public void Atualizar()
        {
            int Qtde_Total = 0;
            double Valor_Total = 0;

            lb_Itens.Items.Clear();
            foreach (Item_Pedido Item in Ped.Lista_Itens)
            {
                Qtde_Total += Item.Qtde;
                Valor_Total += Item.Valor();
                lb_Itens.Items.Add("Cód.: " + Item.Prod.Codigo + " Qtde: " + Item.Qtde + " Valor: "+ Item.Valor());
            }
            this.tb_Qtde.Text = Qtde_Total.ToString();
            this.tb_Valor.Text = Valor_Total.ToString();
        }

        private void btn_Itens_Click(object sender, EventArgs e)
        {
            w_Add_Itens w_Itens = new w_Add_Itens(this.Ped, this.l_Prod, this); ;
            w_Itens.ShowDialog();
            
        }
    }
}
