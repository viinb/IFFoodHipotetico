namespace IF_FOOD
{
    public partial class w_Lista_Produtos : Form
    {
        List<Produto> l_Prod;


        public w_Lista_Produtos(List<Produto> Lista) : this()
        {
            this.l_Prod = Lista;
        }

        public w_Lista_Produtos()
        {
            InitializeComponent();
        }

        private void w_Lista_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Produto P = new Produto();
            w_Det_Produto w_Det = new w_Det_Produto(P);
            w_Det.ShowDialog();

            if (P.Desc != "") //Cadastrou!!!
            {
                this.l_Prod.Add(P);
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            List<string> Lista = new List<string>();

            foreach (Produto P in this.l_Prod)
            {
                Lista.Add("Cód: " + P.Codigo + " Descr.:" + P.Desc + " Qtde.:" + P.Qtde + " Preço: " + P.Preco);
            }

            w_Imp_Lista w_Imp = new w_Imp_Lista(Lista, "Produtos");
            w_Imp.ShowDialog();
        }
    }
}
