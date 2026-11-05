namespace IF_FOOD
{
    partial class w_Det_Item_Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Codigo = new Label();
            tb_Codigo = new TextBox();
            tb_Descricao = new TextBox();
            label1 = new Label();
            tb_Qtde = new TextBox();
            lbl_Qtde = new Label();
            tb_Valor = new TextBox();
            lbl_Valor = new Label();
            btn_Add = new Button();
            btn_Fechar = new Button();
            SuspendLayout();
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Codigo.Location = new Point(45, 33);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(84, 30);
            lbl_Codigo.TabIndex = 0;
            lbl_Codigo.Text = "Código:";
            // 
            // tb_Codigo
            // 
            tb_Codigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Codigo.Location = new Point(132, 33);
            tb_Codigo.Name = "tb_Codigo";
            tb_Codigo.ReadOnly = true;
            tb_Codigo.Size = new Size(189, 35);
            tb_Codigo.TabIndex = 1;
            // 
            // tb_Descricao
            // 
            tb_Descricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Descricao.Location = new Point(132, 74);
            tb_Descricao.Name = "tb_Descricao";
            tb_Descricao.ReadOnly = true;
            tb_Descricao.Size = new Size(300, 35);
            tb_Descricao.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 2;
            label1.Text = "Descrição:";
            // 
            // tb_Qtde
            // 
            tb_Qtde.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Qtde.Location = new Point(132, 115);
            tb_Qtde.Name = "tb_Qtde";
            tb_Qtde.Size = new Size(95, 35);
            tb_Qtde.TabIndex = 5;
            tb_Qtde.TextChanged += tb_Qtde_TextChanged;
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.AutoSize = true;
            lbl_Qtde.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Qtde.Location = new Point(2, 115);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(127, 30);
            lbl_Qtde.TabIndex = 4;
            lbl_Qtde.Text = "Quantidade:";
            // 
            // tb_Valor
            // 
            tb_Valor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Valor.Location = new Point(132, 156);
            tb_Valor.Name = "tb_Valor";
            tb_Valor.ReadOnly = true;
            tb_Valor.Size = new Size(95, 35);
            tb_Valor.TabIndex = 7;
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor.Location = new Point(45, 156);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(64, 30);
            lbl_Valor.TabIndex = 6;
            lbl_Valor.Text = "Valor:";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(89, 221);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(138, 48);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Adicionar";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Fechar.Location = new Point(271, 221);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(138, 48);
            btn_Fechar.TabIndex = 9;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // w_Det_Item_Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 290);
            Controls.Add(btn_Fechar);
            Controls.Add(btn_Add);
            Controls.Add(tb_Valor);
            Controls.Add(lbl_Valor);
            Controls.Add(tb_Qtde);
            Controls.Add(lbl_Qtde);
            Controls.Add(tb_Descricao);
            Controls.Add(label1);
            Controls.Add(tb_Codigo);
            Controls.Add(lbl_Codigo);
            Name = "w_Det_Item_Pedido";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes do Produto";
            Load += w_Det_Item_Pedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Codigo;
        private TextBox tb_Codigo;
        private TextBox tb_Descricao;
        private Label label1;
        private TextBox tb_Qtde;
        private Label lbl_Qtde;
        private TextBox tb_Valor;
        private Label lbl_Valor;
        private Button btn_Add;
        private Button btn_Fechar;
    }
}