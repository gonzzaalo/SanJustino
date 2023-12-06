namespace SanJustino.Forms.Profes
{
    partial class FrmNuevoEditarProfe
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
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(244, 292);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 45);
            btnGuardar.TabIndex = 0;
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
            btnCancelar.Location = new Point(539, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 105);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(350, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 20);
            txtNombre.TabIndex = 3;
            // 
            // FrmNuevoEditarProfe
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 509);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmNuevoEditarProfe";
            Text = "FrmNuevoEditarProfe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label label1;
        private TextBox txtNombre;
    }
}