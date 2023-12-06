namespace SanJustino.Forms.Provincias
{
    partial class FrmProvincias
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
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dataGridProvincias = new DataGridView();
            txtBusqueda = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProvincias).BeginInit();
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
            btnSalir.Location = new Point(776, 453);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 42);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
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
            btnEliminar.Location = new Point(597, 421);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Yellow;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(394, 421);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(83, 42);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(192, 421);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(83, 42);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridProvincias
            // 
            dataGridProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProvincias.BackgroundColor = Color.LightGreen;
            dataGridProvincias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProvincias.GridColor = Color.DarkGreen;
            dataGridProvincias.Location = new Point(12, 62);
            dataGridProvincias.Name = "dataGridProvincias";
            dataGridProvincias.RowTemplate.Height = 25;
            dataGridProvincias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProvincias.Size = new Size(856, 333);
            dataGridProvincias.TabIndex = 9;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(280, 22);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(339, 23);
            txtBusqueda.TabIndex = 8;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 7;
            label1.Text = "Buscar:";
            // 
            // FrmProvincias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 507);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridProvincias);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Name = "FrmProvincias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmProvincias";
            ((System.ComponentModel.ISupportInitialize)dataGridProvincias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dataGridProvincias;
        private TextBox txtBusqueda;
        private Label label1;
    }
}