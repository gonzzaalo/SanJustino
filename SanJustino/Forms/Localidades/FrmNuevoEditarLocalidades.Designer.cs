namespace SanJustino.Forms.Localidades
{
    partial class FrmNuevoEditarLocalidades
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
            txtNombre = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtLocalidad = new TextBox();
            btnNuevoAgregarProvincia = new Button();
            cboProvincia = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 93);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 186);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Código Postal:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(272, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(544, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(272, 178);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(282, 23);
            txtLocalidad.TabIndex = 6;
            // 
            // btnNuevoAgregarProvincia
            // 
            btnNuevoAgregarProvincia.Location = new Point(583, 255);
            btnNuevoAgregarProvincia.Name = "btnNuevoAgregarProvincia";
            btnNuevoAgregarProvincia.Size = new Size(36, 23);
            btnNuevoAgregarProvincia.TabIndex = 21;
            btnNuevoAgregarProvincia.Text = "...";
            btnNuevoAgregarProvincia.UseVisualStyleBackColor = true;
            btnNuevoAgregarProvincia.Click += btnNuevoAgregarProvincia_Click;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(272, 251);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(282, 23);
            cboProvincia.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(144, 259);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 19;
            label7.Text = "Provincia:";
            // 
            // FrmNuevoEditarLocalidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoAgregarProvincia);
            Controls.Add(cboProvincia);
            Controls.Add(label7);
            Controls.Add(txtLocalidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevoEditarLocalidades";
            Text = "FrmNuevoEditarLocalidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtLocalidad;
        private Button btnNuevoAgregarProvincia;
        private ComboBox cboProvincia;
        private Label label7;
    }
}