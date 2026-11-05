namespace IF_FOOD
{
    partial class w_Det_Pedido
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
            btn_Cancelar = new Button();
            btn_OK = new Button();
            tb_Valor = new TextBox();
            lbl_Valor = new Label();
            tb_Qtde = new TextBox();
            lbl_Qtde = new Label();
            tb_Codigo = new TextBox();
            lbl_Codigo = new Label();
            btn_Itens = new Button();
            lb_Itens = new ListBox();
            SuspendLayout();
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(312, 140);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(138, 48);
            btn_Cancelar.TabIndex = 19;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_OK
            // 
            btn_OK.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OK.Location = new Point(136, 140);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(138, 48);
            btn_OK.TabIndex = 18;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // tb_Valor
            // 
            tb_Valor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Valor.Location = new Point(355, 71);
            tb_Valor.Name = "tb_Valor";
            tb_Valor.ReadOnly = true;
            tb_Valor.Size = new Size(95, 35);
            tb_Valor.TabIndex = 17;
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor.Location = new Point(268, 71);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(62, 30);
            lbl_Valor.TabIndex = 16;
            lbl_Valor.Text = "Total:";
            // 
            // tb_Qtde
            // 
            tb_Qtde.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Qtde.Location = new Point(136, 71);
            tb_Qtde.Name = "tb_Qtde";
            tb_Qtde.ReadOnly = true;
            tb_Qtde.Size = new Size(95, 35);
            tb_Qtde.TabIndex = 15;
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.AutoSize = true;
            lbl_Qtde.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Qtde.Location = new Point(6, 71);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(127, 30);
            lbl_Qtde.TabIndex = 14;
            lbl_Qtde.Text = "Quantidade:";
            // 
            // tb_Codigo
            // 
            tb_Codigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Codigo.Location = new Point(136, 23);
            tb_Codigo.Name = "tb_Codigo";
            tb_Codigo.ReadOnly = true;
            tb_Codigo.Size = new Size(189, 35);
            tb_Codigo.TabIndex = 11;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Codigo.Location = new Point(49, 23);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(84, 30);
            lbl_Codigo.TabIndex = 10;
            lbl_Codigo.Text = "Código:";
            // 
            // btn_Itens
            // 
            btn_Itens.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Itens.Location = new Point(364, 16);
            btn_Itens.Name = "btn_Itens";
            btn_Itens.Size = new Size(138, 48);
            btn_Itens.TabIndex = 20;
            btn_Itens.Text = "Itens...";
            btn_Itens.UseVisualStyleBackColor = true;
            btn_Itens.Click += btn_Itens_Click;
            // 
            // lb_Itens
            // 
            lb_Itens.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Itens.FormattingEnabled = true;
            lb_Itens.ItemHeight = 30;
            lb_Itens.Location = new Point(12, 216);
            lb_Itens.Name = "lb_Itens";
            lb_Itens.Size = new Size(538, 274);
            lb_Itens.TabIndex = 21;
            // 
            // w_Det_Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 530);
            Controls.Add(lb_Itens);
            Controls.Add(btn_Itens);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_OK);
            Controls.Add(tb_Valor);
            Controls.Add(lbl_Valor);
            Controls.Add(tb_Qtde);
            Controls.Add(lbl_Qtde);
            Controls.Add(tb_Codigo);
            Controls.Add(lbl_Codigo);
            Name = "w_Det_Pedido";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes do Pedido";
            Load += Det_Pedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_OK;
        private TextBox tb_Valor;
        private Label lbl_Valor;
        private TextBox tb_Qtde;
        private Label lbl_Qtde;
        private TextBox tb_Codigo;
        private Label lbl_Codigo;
        private Button btn_Itens;
        private ListBox lb_Itens;
    }
}