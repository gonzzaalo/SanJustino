namespace SanJustino.Forms.Deportes
{
    partial class FrmNuevoEditarDeporte
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
            txtHorario = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cboProfesor = new ComboBox();
            btnAgregarModoficarProfes = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 67);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 146);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Horrario:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(281, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(281, 138);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(320, 23);
            txtHorario.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(281, 301);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 36);
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
            btnCancelar.Location = new Point(515, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 227);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Profesor:";
            // 
            // cboProfesor
            // 
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.FormattingEnabled = true;
            cboProfesor.Location = new Point(281, 224);
            cboProfesor.Name = "cboProfesor";
            cboProfesor.Size = new Size(320, 23);
            cboProfesor.TabIndex = 7;
            // 
            // btnAgregarModoficarProfes
            // 
            btnAgregarModoficarProfes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregarModoficarProfes.IconColor = Color.Black;
            btnAgregarModoficarProfes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarModoficarProfes.Location = new Point(624, 223);
            btnAgregarModoficarProfes.Name = "btnAgregarModoficarProfes";
            btnAgregarModoficarProfes.Size = new Size(45, 24);
            btnAgregarModoficarProfes.TabIndex = 8;
            btnAgregarModoficarProfes.Text = "...";
            btnAgregarModoficarProfes.UseVisualStyleBackColor = true;
            btnAgregarModoficarProfes.Click += btnAgregarModoficarProfes_Click;
            // 
            // FrmNuevoEditarDeporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarModoficarProfes);
            Controls.Add(cboProfesor);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtHorario);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevoEditarDeporte";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmNuevoEditarDeporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtHorario;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label label3;
        private ComboBox cboProfesor;
        private FontAwesome.Sharp.IconButton btnAgregarModoficarProfes;
    }
}