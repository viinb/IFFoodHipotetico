namespace IF_FOOD
{
    partial class w_Lista_Pedidos
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
            btn_Imprimir = new Button();
            btn_Cadastrar = new Button();
            SuspendLayout();
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Imprimir.Location = new Point(53, 156);
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(348, 80);
            btn_Imprimir.TabIndex = 5;
            btn_Imprimir.Text = "Imprimir Pedidos";
            btn_Imprimir.UseVisualStyleBackColor = true;
            btn_Imprimir.Click += btn_Imprimir_Click;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cadastrar.Location = new Point(53, 56);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(348, 80);
            btn_Cadastrar.TabIndex = 4;
            btn_Cadastrar.Text = "Cadastrar Pedidos";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // w_Lista_Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 292);
            Controls.Add(btn_Imprimir);
            Controls.Add(btn_Cadastrar);
            Name = "w_Lista_Pedidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de Pedidos";
            Load += w_Lista_Pedidos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Imprimir;
        private Button btn_Cadastrar;
    }
}