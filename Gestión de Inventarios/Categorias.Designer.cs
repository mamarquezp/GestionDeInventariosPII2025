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
            btnEditarCategoria = new Button();
            btnEliminarCategoria = new Button();
            dgvCategorias = new DataGridView();
            idCategoria = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(157, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Categorías";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(125, 85);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre categoría:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(270, 85);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(152, 23);
            txtNombreCategoria.TabIndex = 2;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.AutoSize = true;
            btnAgregarCategoria.Font = new Font("Segoe UI", 12F);
            btnAgregarCategoria.Location = new Point(137, 140);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(76, 31);
            btnAgregarCategoria.TabIndex = 3;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.AutoSize = true;
            btnEditarCategoria.Font = new Font("Segoe UI", 12F);
            btnEditarCategoria.Location = new Point(241, 140);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(75, 31);
            btnEditarCategoria.TabIndex = 4;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.AutoSize = true;
            btnEliminarCategoria.Font = new Font("Segoe UI", 12F);
            btnEliminarCategoria.Location = new Point(346, 140);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(77, 31);
            btnEliminarCategoria.TabIndex = 5;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { idCategoria, categoria });
            dgvCategorias.Location = new Point(54, 207);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(451, 342);
            dgvCategorias.TabIndex = 6;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "ID";
            idCategoria.Name = "idCategoria";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoría";
            categoria.Name = "categoria";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 600);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Categorias";
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCategoria;
        private Button btnAgregarCategoria;
        private Button btnEditarCategoria;
        private Button btnEliminarCategoria;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn categoria;
    }
}