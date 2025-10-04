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
            lblTituloDash = new Label();
            lblProductos = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCategorias = new Label();
            lblValor = new Label();
            label5 = new Label();
            lblMayorStock = new Label();
            lblValorInventario = new Label();
            lblTotalCategorias = new Label();
            lblTotalProductos = new Label();
            groupBox1 = new GroupBox();
            btnMovimientos = new Button();
            btnProductos = new Button();
            btnCategorias = new Button();
            lblTituloBotones = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloDash
            // 
            lblTituloDash.AutoSize = true;
            lblTituloDash.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloDash.Location = new Point(417, 9);
            lblTituloDash.Name = "lblTituloDash";
            lblTituloDash.Size = new Size(171, 41);
            lblTituloDash.TabIndex = 0;
            lblTituloDash.Text = "Dashboard";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblProductos.Location = new Point(6, 23);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(203, 28);
            lblProductos.TabIndex = 1;
            lblProductos.Text = "Productos registrados:";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblCategorias.Location = new Point(4, 23);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(210, 28);
            lblCategorias.TabIndex = 2;
            lblCategorias.Text = "Categorías registradas:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblValor.Location = new Point(6, 23);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(200, 28);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor total inventario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(243, 28);
            label5.TabIndex = 4;
            label5.Text = "Producto con mayor stock:";
            // 
            // lblMayorStock
            // 
            lblMayorStock.AutoSize = true;
            lblMayorStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblMayorStock.Location = new Point(6, 93);
            lblMayorStock.Name = "lblMayorStock";
            lblMayorStock.Size = new Size(20, 28);
            lblMayorStock.TabIndex = 8;
            lblMayorStock.Text = "-";
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblValorInventario.Location = new Point(51, 95);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(24, 28);
            lblValorInventario.TabIndex = 7;
            lblValorInventario.Text = "0";
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalCategorias.Location = new Point(92, 93);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(24, 28);
            lblTotalCategorias.TabIndex = 6;
            lblTotalCategorias.Text = "0";
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductos.Location = new Point(89, 95);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(24, 28);
            lblTotalProductos.TabIndex = 5;
            lblTotalProductos.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblProductos);
            groupBox1.Controls.Add(lblTotalProductos);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 166);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnMovimientos
            // 
            btnMovimientos.AutoSize = true;
            btnMovimientos.Font = new Font("Segoe UI", 13.8F);
            btnMovimientos.Location = new Point(627, 340);
            btnMovimientos.Margin = new Padding(3, 4, 3, 4);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(157, 56);
            btnMovimientos.TabIndex = 13;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnProductos
            // 
            btnProductos.AutoSize = true;
            btnProductos.Font = new Font("Segoe UI", 13.8F);
            btnProductos.Location = new Point(421, 340);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(157, 56);
            btnProductos.TabIndex = 12;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.AutoSize = true;
            btnCategorias.Font = new Font("Segoe UI", 13.8F);
            btnCategorias.Location = new Point(206, 340);
            btnCategorias.Margin = new Padding(3, 4, 3, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(157, 56);
            btnCategorias.TabIndex = 11;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // lblTituloBotones
            // 
            lblTituloBotones.AutoSize = true;
            lblTituloBotones.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloBotones.Location = new Point(359, 263);
            lblTituloBotones.Name = "lblTituloBotones";
            lblTituloBotones.Size = new Size(321, 41);
            lblTituloBotones.TabIndex = 10;
            lblTituloBotones.Text = "Gestión de Inventario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCategorias);
            groupBox2.Controls.Add(lblTotalCategorias);
            groupBox2.Location = new Point(257, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 166);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblValor);
            groupBox3.Controls.Add(lblValorInventario);
            groupBox3.Location = new Point(503, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 166);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(lblMayorStock);
            groupBox4.Location = new Point(744, 69);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 166);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 502);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Controls.Add(lblTituloBotones);
            Controls.Add(lblTituloDash);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Activated += Dashboard_Activated;
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloDash;
        private Label lblProductos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCategorias;
        private Label lblValor;
        private Label label5;
        private Label lblMayorStock;
        private Label lblValorInventario;
        private Label lblTotalCategorias;
        private Label lblTotalProductos;
        private GroupBox groupBox1;
        private Button btnMovimientos;
        private Button btnProductos;
        private Button btnCategorias;
        private Label lblTituloBotones;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}