namespace SanJustino.Forms
{
    partial class FrmDeportistas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridDeportistas = new DataGridView();
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            Modificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridDeportistas).BeginInit();
            SuspendLayout();
            // 
            // dataGridDeportistas
            // 
            dataGridDeportistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDeportistas.BackgroundColor = Color.LightGreen;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDeportistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDeportistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDeportistas.GridColor = Color.DarkGreen;
            dataGridDeportistas.Location = new Point(12, 54);
            dataGridDeportistas.Name = "dataGridDeportistas";
            dataGridDeportistas.RowTemplate.Height = 25;
            dataGridDeportistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDeportistas.Size = new Size(845, 351);
            dataGridDeportistas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(248, 12);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(290, 23);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(124, 439);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(85, 42);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.Yellow;
            Modificar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Modificar.ForeColor = SystemColors.ControlText;
            Modificar.IconChar = FontAwesome.Sharp.IconChar.None;
            Modificar.IconColor = Color.Black;
            Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Modificar.Location = new Point(345, 439);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(85, 42);
            Modificar.TabIndex = 4;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(558, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 42);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Blue;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(772, 458);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 42);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmDeportistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 512);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(Modificar);
            Controls.Add(btnNuevo);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(dataGridDeportistas);
            Name = "FrmDeportistas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDeportistas";
            ((System.ComponentModel.ISupportInitialize)dataGridDeportistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridDeportistas;
        private Label label1;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton Modificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}