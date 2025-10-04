
namespace Gestión_de_Inventarios
{
    partial class Categorias
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
            txtNombreCategoria = new TextBox();
            btnAgregarCategoria = new Button();
            btnEditarGuardar = new Button();
            btnEliminarCategoria = new Button();
            dgvCategorias = new DataGridView();
            btnCancelar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(179, 31);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Categorías";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(143, 113);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre categoría:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(309, 113);
            txtNombreCategoria.Margin = new Padding(3, 4, 3, 4);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(173, 27);
            txtNombreCategoria.TabIndex = 2;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.AutoSize = true;
            btnAgregarCategoria.Font = new Font("Segoe UI", 12F);
            btnAgregarCategoria.Location = new Point(130, 185);
            btnAgregarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(93, 41);
            btnAgregarCategoria.TabIndex = 3;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEditarGuardar
            // 
            btnEditarGuardar.AutoSize = true;
            btnEditarGuardar.Font = new Font("Segoe UI", 12F);
            btnEditarGuardar.Location = new Point(327, 185);
            btnEditarGuardar.Margin = new Padding(3, 4, 3, 4);
            btnEditarGuardar.Name = "btnEditarGuardar";
            btnEditarGuardar.Size = new Size(151, 41);
            btnEditarGuardar.TabIndex = 4;
            btnEditarGuardar.Text = "Editar";
            btnEditarGuardar.UseVisualStyleBackColor = true;
            btnEditarGuardar.Click += btnEditarGuardar_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.AutoSize = true;
            btnEliminarCategoria.Font = new Font("Segoe UI", 12F);
            btnEliminarCategoria.Location = new Point(229, 185);
            btnEliminarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(92, 41);
            btnEliminarCategoria.TabIndex = 5;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre });
            dgvCategorias.Location = new Point(62, 276);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(515, 456);
            dgvCategorias.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(484, 185);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Categoría";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 800);
            Controls.Add(btnCancelar);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnEditarGuardar);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Categorias";
            Text = "Categorias";
            Load += Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCategoria;
        private Button btnAgregarCategoria;
        private Button btnEditarGuardar;
        private Button btnEliminarCategoria;
        private DataGridView dgvCategorias;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
    }
}