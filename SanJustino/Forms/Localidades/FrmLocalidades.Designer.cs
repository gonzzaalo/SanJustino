namespace SanJustino.Forms.Localidades
{
    partial class FrmLocalidades
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
            txtBusqueda = new TextBox();
            label1 = new Label();
            dataGridLocalidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
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
            btnNuevo.Location = new Point(203, 407);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 38);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "&Nuevo";
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
            btnModificar.Location = new Point(393, 407);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 38);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "&Modificar";
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
            btnEliminar.Location = new Point(563, 407);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "&Eliminar";
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
            btnSalir.Location = new Point(794, 445);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(275, 21);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(368, 23);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 5;
            label1.Text = "Buscar:";
            // 
            // dataGridLocalidades
            // 
            dataGridLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLocalidades.BackgroundColor = Color.LightGreen;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(12, 60);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.RowTemplate.Height = 25;
            dataGridLocalidades.Size = new Size(862, 318);
            dataGridLocalidades.TabIndex = 6;
            // 
            // FrmLocalidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 495);
            Controls.Add(dataGridLocalidades);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "FrmLocalidades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmLocalidades";
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridView dataGridLocalidades;
    }
}