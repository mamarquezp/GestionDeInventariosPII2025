namespace Gestión_de_Inventarios
{
    partial class Movimientos
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
            cmbProducto = new ComboBox();
            numCantidad = new NumericUpDown();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            dgvMovimientos = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            btnRegistrarSalida = new Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(261, 37);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "Movimientos de Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(198, 116);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(198, 157);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(306, 119);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(187, 28);
            cmbProducto.TabIndex = 4;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(306, 161);
            numCantidad.Margin = new Padding(3, 4, 3, 4);
            numCantidad.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(109, 27);
            numCantidad.TabIndex = 5;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.AutoSize = true;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 12F);
            btnRegistrarEntrada.Location = new Point(198, 213);
            btnRegistrarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(211, 41);
            btnRegistrarEntrada.TabIndex = 7;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(745, 213);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 41);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { fecha, producto, tipo, cantidad });
            dgvMovimientos.Location = new Point(30, 262);
            dgvMovimientos.Margin = new Padding(3, 4, 3, 4);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(811, 535);
            dgvMovimientos.TabIndex = 9;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "Fecha";
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 125;
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
            // tipo
            // 
            tipo.DataPropertyName = "TipoMovimiento";
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            tipo.Width = 125;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Cantidad";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 125;
            // 
            // btnRegistrarSalida
            // 
            btnRegistrarSalida.AutoSize = true;
            btnRegistrarSalida.Font = new Font("Segoe UI", 12F);
            btnRegistrarSalida.Location = new Point(415, 213);
            btnRegistrarSalida.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarSalida.Name = "btnRegistrarSalida";
            btnRegistrarSalida.Size = new Size(211, 41);
            btnRegistrarSalida.TabIndex = 10;
            btnRegistrarSalida.Text = "Registrar Salida";
            btnRegistrarSalida.UseVisualStyleBackColor = true;
            btnRegistrarSalida.Click += btnRegistrarSalida_Click;
            // 
            // Movimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 840);
            Controls.Add(btnRegistrarSalida);
            Controls.Add(dgvMovimientos);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(numCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Movimientos";
            Text = "Movimientos";
            Load += Movimientos_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbProducto;
        private NumericUpDown numCantidad;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private DataGridView dgvMovimientos;
        private Button btnRegistrarSalida;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn cantidad;
    }
}