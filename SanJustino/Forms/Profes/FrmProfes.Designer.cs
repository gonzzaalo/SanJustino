namespace SanJustino.Forms.Profes
{
    partial class FrmProfes
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
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtBusqueda = new TextBox();
            dataGridProfesores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridProfesores).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(223, 441);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 36);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Yellow;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(397, 441);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 36);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(563, 441);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Blue;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(778, 461);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 4;
            label1.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(278, 27);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(339, 23);
            txtBusqueda.TabIndex = 5;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dataGridProfesores
            // 
            dataGridProfesores.BackgroundColor = Color.LightGreen;
            dataGridProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProfesores.Location = new Point(12, 72);
            dataGridProfesores.Name = "dataGridProfesores";
            dataGridProfesores.RowTemplate.Height = 25;
            dataGridProfesores.Size = new Size(859, 341);
            dataGridProfesores.TabIndex = 6;
            // 
            // FrmProfes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 509);
            Controls.Add(dataGridProfesores);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "FrmProfes";
            Text = "FrmProfes";
            ((System.ComponentModel.ISupportInitialize)dataGridProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Label label1;
        private TextBox txtBusqueda;
        private DataGridView dataGridProfesores;
    }
}