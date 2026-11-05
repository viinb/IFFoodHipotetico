namespace IF_FOOD
{
    partial class w_Det_Produto
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
            tb_Preco = new TextBox();
            lbl_Preco = new Label();
            btn_OK = new Button();
            btn_Cancelar = new Button();
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
            // tb_Preco
            // 
            tb_Preco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Preco.Location = new Point(132, 156);
            tb_Preco.Name = "tb_Preco";
            tb_Preco.Size = new Size(95, 35);
            tb_Preco.TabIndex = 7;
            // 
            // lbl_Preco
            // 
            lbl_Preco.AutoSize = true;
            lbl_Preco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Preco.Location = new Point(45, 156);
            lbl_Preco.Name = "lbl_Preco";
            lbl_Preco.Size = new Size(70, 30);
            lbl_Preco.TabIndex = 6;
            lbl_Preco.Text = "Preço:";
            // 
            // btn_OK
            // 
            btn_OK.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OK.Location = new Point(89, 221);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(138, 48);
            btn_OK.TabIndex = 8;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(271, 221);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(138, 48);
            btn_Cancelar.TabIndex = 9;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // w_Det_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 290);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_OK);
            Controls.Add(tb_Preco);
            Controls.Add(lbl_Preco);
            Controls.Add(tb_Qtde);
            Controls.Add(lbl_Qtde);
            Controls.Add(tb_Descricao);
            Controls.Add(label1);
            Controls.Add(tb_Codigo);
            Controls.Add(lbl_Codigo);
            Name = "w_Det_Produto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes do Produto";
            Load += w_Det_Produto_Load;
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
        private TextBox tb_Preco;
        private Label lbl_Preco;
        private Button btn_OK;
        private Button btn_Cancelar;
    }
}