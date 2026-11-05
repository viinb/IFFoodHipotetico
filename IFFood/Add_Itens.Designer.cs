namespace IF_FOOD
{
    partial class w_Add_Itens
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
            lb_Lista = new ListBox();
            btn_Fechar = new Button();
            SuspendLayout();
            // 
            // lb_Lista
            // 
            lb_Lista.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Lista.FormattingEnabled = true;
            lb_Lista.ItemHeight = 30;
            lb_Lista.Location = new Point(6, 10);
            lb_Lista.Name = "lb_Lista";
            lb_Lista.Size = new Size(525, 274);
            lb_Lista.TabIndex = 0;
            lb_Lista.SelectedIndexChanged += lb_Lista_SelectedIndexChanged;
            lb_Lista.DoubleClick += lb_Lista_DoubleClick;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Fechar.Location = new Point(212, 305);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(138, 48);
            btn_Fechar.TabIndex = 9;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // w_Add_Itens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 368);
            Controls.Add(btn_Fechar);
            Controls.Add(lb_Lista);
            Name = "w_Add_Itens";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de Produtos";
            Load += Add_Itens_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_Lista;
        private Button btn_Fechar;
    }
}