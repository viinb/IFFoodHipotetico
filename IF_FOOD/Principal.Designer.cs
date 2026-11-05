namespace IF_FOOD
{
    partial class w_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Admin = new Button();
            btn_Vendas = new Button();
            SuspendLayout();
            // 
            // btn_Admin
            // 
            btn_Admin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Admin.Location = new Point(134, 54);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(348, 80);
            btn_Admin.TabIndex = 0;
            btn_Admin.Text = "Administração";
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_Vendas
            // 
            btn_Vendas.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Vendas.Location = new Point(134, 154);
            btn_Vendas.Name = "btn_Vendas";
            btn_Vendas.Size = new Size(348, 80);
            btn_Vendas.TabIndex = 1;
            btn_Vendas.Text = "Vendas";
            btn_Vendas.UseVisualStyleBackColor = true;
            btn_Vendas.Click += btn_Vendas_Click;
            // 
            // w_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 321);
            Controls.Add(btn_Vendas);
            Controls.Add(btn_Admin);
            Name = "w_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IF_FOOD - Restaurante";
            Load += w_Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Admin;
        private Button btn_Vendas;
    }
}
