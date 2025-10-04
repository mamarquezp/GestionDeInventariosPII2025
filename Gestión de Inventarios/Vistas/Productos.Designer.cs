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
            btnEditarGuardar = new Button();
            btnAgregarProducto = new Button();
            dgvProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(221, 24);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(165, 83);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(165, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(165, 175);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 3;
            label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(165, 221);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 4;
            label5.Text = "Cantidad inicial:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(339, 85);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(221, 27);
            txtNombreProducto.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(339, 129);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(199, 28);
            cmbCategoria.TabIndex = 6;
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.DecimalPlaces = 2;
            numPrecioUnitario.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numPrecioUnitario.Location = new Point(339, 179);
            numPrecioUnitario.Margin = new Padding(3, 4, 3, 4);
            numPrecioUnitario.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(111, 27);
            numPrecioUnitario.TabIndex = 7;
            // 
            // numCantidadInicial
            // 
            numCantidadInicial.Location = new Point(339, 225);
            numCantidadInicial.Margin = new Padding(3, 4, 3, 4);
            numCantidadInicial.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numCantidadInicial.Name = "numCantidadInicial";
            numCantidadInicial.Size = new Size(78, 27);
            numCantidadInicial.TabIndex = 8;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.AutoSize = true;
            btnEliminarProducto.Font = new Font("Segoe UI", 12F);
            btnEliminarProducto.Location = new Point(299, 293);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(92, 41);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnEditarGuardar
            // 
            btnEditarGuardar.AutoSize = true;
            btnEditarGuardar.Font = new Font("Segoe UI", 12F);
            btnEditarGuardar.Location = new Point(424, 293);
            btnEditarGuardar.Margin = new Padding(3, 4, 3, 4);
            btnEditarGuardar.Name = "btnEditarGuardar";
            btnEditarGuardar.Size = new Size(210, 41);
            btnEditarGuardar.TabIndex = 10;
            btnEditarGuardar.Text = "Editar";
            btnEditarGuardar.UseVisualStyleBackColor = true;
            btnEditarGuardar.Click += btnEditarGuardar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSize = true;
            btnAgregarProducto.Font = new Font("Segoe UI", 12F);
            btnAgregarProducto.Location = new Point(173, 293);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(93, 41);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id, producto, categoria, precio, cantidad });
            dgvProductos.Location = new Point(29, 357);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(766, 444);
            dgvProductos.TabIndex = 12;
            // 
            // id
            // 
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // producto
            // 
            producto.DataPropertyName = "Producto";
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 125;
            // 
            // categoria
            // 
            categoria.DataPropertyName = "Categoria";
            categoria.HeaderText = "Categoría";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 125;
            // 
            // precio
            // 
            precio.DataPropertyName = "Precio";
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Stock";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 125;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(699, 293);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 41);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 829);
            Controls.Add(btnCancelar);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarGuardar);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
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
        private Button btnEditarGuardar;
        private Button btnAgregarProducto;
        private DataGridView dgvProductos;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
    }
}