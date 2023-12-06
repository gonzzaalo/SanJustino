namespace SanJustino.Forms.Deportes
{
    partial class FrmDeportes
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
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            Modificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            label1 = new Label();
            dataGridDeportes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDeportes).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Blue;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(766, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 42);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(549, 436);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.Yellow;
            Modificar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Modificar.IconChar = FontAwesome.Sharp.IconChar.None;
            Modificar.IconColor = Color.Black;
            Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Modificar.Location = new Point(344, 436);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(89, 42);
            Modificar.TabIndex = 11;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(144, 436);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(87, 42);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(286, 12);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(290, 23);
            txtBusqueda.TabIndex = 9;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Buscar:";
            // 
            // dataGridDeportes
            // 
            dataGridDeportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDeportes.BackgroundColor = Color.LightGreen;
            dataGridDeportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDeportes.GridColor = Color.LightGreen;
            dataGridDeportes.Location = new Point(12, 60);
            dataGridDeportes.Name = "dataGridDeportes";
            dataGridDeportes.RowTemplate.Height = 25;
            dataGridDeportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDeportes.Size = new Size(856, 351);
            dataGridDeportes.TabIndex = 7;
            // 
            // FrmDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 513);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(Modificar);
            Controls.Add(btnNuevo);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(dataGridDeportes);
            Name = "FrmDeportes";
            Text = "FrmDeportes";
            ((System.ComponentModel.ISupportInitialize)dataGridDeportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton Modificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridView dataGridDeportes;
    }
}