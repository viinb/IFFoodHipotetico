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
    public partial class w_Det_Produto : Form
    {
        Produto Prod;

        public w_Det_Produto()
        {
            InitializeComponent();
        }
        public w_Det_Produto(Produto P) : this()
        {
            this.Prod = P;
        }


        private void w_Det_Produto_Load(object sender, EventArgs e)
        {
            tb_Codigo.Text = this.Prod.Codigo;
            tb_Descricao.Text = this.Prod.Desc;
            tb_Qtde.Text = this.Prod.Qtde.ToString();
            tb_Preco.Text = this.Prod.Preco.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {           
            this.Prod.Desc = tb_Descricao.Text;
            this.Prod.Qtde = Int32.Parse(tb_Qtde.Text);
            this.Prod.Preco = Double.Parse(tb_Preco.Text);

            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
