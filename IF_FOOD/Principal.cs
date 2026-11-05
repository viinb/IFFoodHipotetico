namespace IF_FOOD
{
    public partial class w_Principal : Form
    {
        List<Produto> l_Prod = new List<Produto>();
        List<Pedido> l_Ped = new List<Pedido>();
        public w_Principal()
        {
            InitializeComponent();
        }

        private void w_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            w_Lista_Produtos w_L_Prod = new w_Lista_Produtos(l_Prod);

            w_L_Prod.ShowDialog();
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            w_Lista_Pedidos w_L_Ped = new w_Lista_Pedidos(l_Prod, l_Ped);

            w_L_Ped.ShowDialog();

        }
    }
}
