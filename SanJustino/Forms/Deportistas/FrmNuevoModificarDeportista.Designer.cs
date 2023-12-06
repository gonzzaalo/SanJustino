namespace SanJustino.Forms
{
    partial class FrmNuevoModificarDeportista
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
            label5 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            cboLocalidad = new ComboBox();
            btnNuevoEditLocalidad = new Button();
            btnNuevoAgregarProvincia = new Button();
            cboProvincia = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 94);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 150);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(158, 198);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 242);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Dirección:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(251, 402);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(531, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(251, 190);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(317, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(251, 234);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(317, 23);
            txtDireccion.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(251, 86);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 23);
            txtApellido.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(158, 287);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 13;
            label6.Text = "Localidad:";
            // 
            // cboLocalidad
            // 
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(251, 279);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(317, 23);
            cboLocalidad.TabIndex = 14;
            // 
            // btnNuevoEditLocalidad
            // 
            btnNuevoEditLocalidad.Location = new Point(590, 283);
            btnNuevoEditLocalidad.Name = "btnNuevoEditLocalidad";
            btnNuevoEditLocalidad.Size = new Size(36, 23);
            btnNuevoEditLocalidad.TabIndex = 15;
            btnNuevoEditLocalidad.Text = "...";
            btnNuevoEditLocalidad.UseVisualStyleBackColor = true;
            btnNuevoEditLocalidad.Click += btnNuevoEditLocalidad_Click;
            // 
            // btnNuevoAgregarProvincia
            // 
            btnNuevoAgregarProvincia.Location = new Point(590, 336);
            btnNuevoAgregarProvincia.Name = "btnNuevoAgregarProvincia";
            btnNuevoAgregarProvincia.Size = new Size(36, 23);
            btnNuevoAgregarProvincia.TabIndex = 24;
            btnNuevoAgregarProvincia.Text = "...";
            btnNuevoAgregarProvincia.UseVisualStyleBackColor = true;
            btnNuevoAgregarProvincia.Click += btnNuevoAgregarProvincia_Click;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(251, 332);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(317, 23);
            cboProvincia.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(158, 340);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 22;
            label7.Text = "Provincia:";
            // 
            // FrmNuevoModificarDeportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoAgregarProvincia);
            Controls.Add(cboProvincia);
            Controls.Add(label7);
            Controls.Add(btnNuevoEditLocalidad);
            Controls.Add(cboLocalidad);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevoModificarDeportista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmNuevoModificarDeportista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private Label label6;
        private ComboBox cboLocalidad;
        private Button btnNuevoEditLocalidad;
        private Button btnNuevoAgregarProvincia;
        private ComboBox cboProvincia;
        private Label label7;
    }
}