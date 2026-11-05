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
    public partial class w_Imp_Lista : Form
    {
        //List<Produto> l_Prod;
        List<string> Lista;

        public w_Imp_Lista(List<string> L, string Tipo) :this()
        {
            this.Lista = L;
            this.Text += Tipo;
        }

        public w_Imp_Lista()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imp_Lista_Load(object sender, EventArgs e)
        {
            //foreach (Produto P in this.l_Prod)
            foreach (string S in this.Lista)
            {
                //lb_Lista.Items.Add("Cód: "+P.Codigo + " Descr.:"+ P.Desc + " Qtde.:"+P.Qtde + " Preço: " +P.Preco);
                lb_Lista.Items.Add(S);
            }

        }
    }
}
