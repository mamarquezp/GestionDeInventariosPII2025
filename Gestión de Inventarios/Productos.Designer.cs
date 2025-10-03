namespace Gestión_de_Inventarios
{
    partial class Productos
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            cmbCategoria = new ComboBox();
            numPrecioUnitario = new NumericUpDown();
            numCantidadInicial = new NumericUpDown();
            btnEliminarProducto = new Button();
            btnEditarProducto = new Button();
            btnAgregarProducto = new Button();
            dgvProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(193, 18);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(153, 62);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(153, 97);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(153, 131);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 3;
            label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(153, 166);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 4;
            label5.Text = "Cantidad inicial:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(297, 64);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(194, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(297, 97);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(175, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(297, 134);
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(97, 23);
            numPrecioUnitario.TabIndex = 7;
            // 
            // numCantidadInicial
            // 
            numCantidadInicial.Location = new Point(297, 169);
            numCantidadInicial.Name = "numCantidadInicial";
            numCantidadInicial.Size = new Size(68, 23);
            numCantidadInicial.TabIndex = 8;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.AutoSize = true;
            btnEliminarProducto.Font = new Font("Segoe UI", 12F);
            btnEliminarProducto.Location = new Point(395, 220);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(77, 31);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.AutoSize = true;
            btnEditarProducto.Font = new Font("Segoe UI", 12F);
            btnEditarProducto.Location = new Point(290, 220);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(75, 31);
            btnEditarProducto.TabIndex = 10;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSize = true;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F);
            btnAgregarProducto.Location = new Point(186, 220);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(76, 31);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id, producto, categoria, precio, cantidad });
            dgvProductos.Location = new Point(25, 268);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(670, 333);
            dgvProductos.TabIndex = 12;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoría";
            categoria.Name = "categoria";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 622);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(numCantidadInicial);
            Controls.Add(numPrecioUnitario);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private ComboBox cmbCategoria;
        private NumericUpDown numPrecioUnitario;
        private NumericUpDown numCantidadInicial;
        private Button btnEliminarProducto;
        private Button btnEditarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
    }
}