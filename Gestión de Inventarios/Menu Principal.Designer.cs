namespace Gestión_de_Inventarios
{
    partial class Menu_Principal
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
            btnCategorias = new Button();
            btnProductos = new Button();
            btnMovimientos = new Button();
            btnDashboard = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(149, 44);
            label1.Name = "label1";
            label1.Size = new Size(480, 65);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Inventario";
            // 
            // btnCategorias
            // 
            btnCategorias.AutoSize = true;
            btnCategorias.Font = new Font("Segoe UI", 18F);
            btnCategorias.Location = new Point(149, 138);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(136, 42);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += button1_Click;
            // 
            // btnProductos
            // 
            btnProductos.AutoSize = true;
            btnProductos.Font = new Font("Segoe UI", 18F);
            btnProductos.Location = new Point(314, 138);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(130, 42);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnMovimientos
            // 
            btnMovimientos.AutoSize = true;
            btnMovimientos.Font = new Font("Segoe UI", 18F);
            btnMovimientos.Location = new Point(465, 138);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(164, 42);
            btnMovimientos.TabIndex = 3;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.Font = new Font("Segoe UI", 18F);
            btnDashboard.Location = new Point(314, 225);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(139, 42);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDashboard);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Controls.Add(label1);
            Name = "Menu_Principal";
            Text = "Menu_Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnMovimientos;
        private Button btnDashboard;
    }
}