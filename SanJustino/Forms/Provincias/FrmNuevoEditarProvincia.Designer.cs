namespace SanJustino.Forms.Provincias
{
    partial class FrmNuevoEditarProvincia
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
            txtNombre = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 124);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(296, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(198, 326);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 37);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "&Guardar";
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
            btnCancelar.Location = new Point(515, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 37);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoEditarProvincia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmNuevoEditarProvincia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmNuevoEditarProvincia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}