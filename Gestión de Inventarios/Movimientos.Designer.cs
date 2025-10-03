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
            label4 = new Label();
            cmbProducto = new ComboBox();
            numCantidad = new NumericUpDown();
            cmbTipo = new ComboBox();
            btnRegistrarMovimiento = new Button();
            btnCancelar = new Button();
            dgvMovimientos = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(228, 28);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 0;
            label1.Text = "Movimientos de Inventario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(173, 87);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(173, 118);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(173, 149);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(268, 89);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(164, 23);
            cmbProducto.TabIndex = 4;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(268, 121);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(95, 23);
            numCantidad.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipo.Location = new Point(268, 151);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 6;
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.AutoSize = true;
            btnRegistrarMovimiento.Font = new Font("Segoe UI", 12F);
            btnRegistrarMovimiento.Location = new Point(228, 203);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(171, 31);
            btnRegistrarMovimiento.TabIndex = 7;
            btnRegistrarMovimiento.Text = "Registrar Movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(440, 203);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { fecha, producto, tipo, cantidad, stock });
            dgvMovimientos.Location = new Point(26, 258);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Size = new Size(710, 340);
            dgvMovimientos.TabIndex = 9;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // Movimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 630);
            Controls.Add(dgvMovimientos);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarMovimiento);
            Controls.Add(cmbTipo);
            Controls.Add(numCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Movimientos";
            Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbProducto;
        private NumericUpDown numCantidad;
        private ComboBox cmbTipo;
        private Button btnRegistrarMovimiento;
        private Button btnCancelar;
        private DataGridView dgvMovimientos;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn stock;
    }
}