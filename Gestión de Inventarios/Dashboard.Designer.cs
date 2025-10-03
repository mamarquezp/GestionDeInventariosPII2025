namespace Gestión_de_Inventarios
{
    partial class Dashboard
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
            label1 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMayorStock = new Label();
            lblValorInventario = new Label();
            lblTotalCategorias = new Label();
            lblTotalProductos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(145, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(103, 93);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Productos registrados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(103, 123);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 2;
            label3.Text = "Categorías registradas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label4.Location = new Point(103, 155);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 3;
            label4.Text = "Valor total inventario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label5.Location = new Point(103, 187);
            label5.Name = "label5";
            label5.Size = new Size(194, 21);
            label5.TabIndex = 4;
            label5.Text = "Producto con mayor stock:";
            // 
            // lblMayorStock
            // 
            lblMayorStock.AutoSize = true;
            lblMayorStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblMayorStock.Location = new Point(309, 187);
            lblMayorStock.Name = "lblMayorStock";
            lblMayorStock.Size = new Size(0, 21);
            lblMayorStock.TabIndex = 8;
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblValorInventario.Location = new Point(309, 155);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(0, 21);
            lblValorInventario.TabIndex = 7;
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalCategorias.Location = new Point(309, 123);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(0, 21);
            lblTotalCategorias.TabIndex = 6;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductos.Location = new Point(309, 93);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(0, 21);
            lblTotalProductos.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 293);
            Controls.Add(lblMayorStock);
            Controls.Add(lblValorInventario);
            Controls.Add(lblTotalCategorias);
            Controls.Add(lblTotalProductos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblMayorStock;
        private Label lblValorInventario;
        private Label lblTotalCategorias;
        private Label lblTotalProductos;
    }
}