namespace SanJustino
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btnDeportes = new FontAwesome.Sharp.IconButton();
            btnDeportista = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            listadoDeDeportistasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            listaDeProfesoresToolStripMenuItem = new ToolStripMenuItem();
            listadoDeDeportesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeportes
            // 
            btnDeportes.BackColor = Color.LimeGreen;
            btnDeportes.BackgroundImage = (Image)resources.GetObject("btnDeportes.BackgroundImage");
            btnDeportes.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeportes.ForeColor = Color.White;
            btnDeportes.IconChar = FontAwesome.Sharp.IconChar.Medal;
            btnDeportes.IconColor = Color.White;
            btnDeportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeportes.Location = new Point(12, 27);
            btnDeportes.Name = "btnDeportes";
            btnDeportes.Size = new Size(114, 93);
            btnDeportes.TabIndex = 0;
            btnDeportes.Text = "DEPORTES";
            btnDeportes.TextAlign = ContentAlignment.BottomCenter;
            btnDeportes.UseVisualStyleBackColor = false;
            btnDeportes.Click += btnDeportes_Click;
            // 
            // btnDeportista
            // 
            btnDeportista.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeportista.BackColor = Color.LimeGreen;
            btnDeportista.BackgroundImage = (Image)resources.GetObject("btnDeportista.BackgroundImage");
            btnDeportista.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeportista.ForeColor = Color.White;
            btnDeportista.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            btnDeportista.IconColor = Color.White;
            btnDeportista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeportista.Location = new Point(750, 36);
            btnDeportista.Name = "btnDeportista";
            btnDeportista.Size = new Size(114, 93);
            btnDeportista.TabIndex = 1;
            btnDeportista.Text = "DEPORTISTAS";
            btnDeportista.TextAlign = ContentAlignment.BottomCenter;
            btnDeportista.UseVisualStyleBackColor = false;
            btnDeportista.Click += btnDeportista_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { listadoDeDeportistasToolStripMenuItem, listaDeProfesoresToolStripMenuItem, listadoDeDeportesToolStripMenuItem, listadoDeProvinciasYSusLocadidaesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 483);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // listadoDeDeportistasToolStripMenuItem
            // 
            listadoDeDeportistasToolStripMenuItem.BackColor = Color.White;
            listadoDeDeportistasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            listadoDeDeportistasToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listadoDeDeportistasToolStripMenuItem.Name = "listadoDeDeportistasToolStripMenuItem";
            listadoDeDeportistasToolStripMenuItem.Size = new Size(151, 20);
            listadoDeDeportistasToolStripMenuItem.Text = "Listado de Deportistas";
            listadoDeDeportistasToolStripMenuItem.Click += listadoDeDeportistasToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            listaDeProfesoresToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            listaDeProfesoresToolStripMenuItem.Size = new Size(132, 20);
            listaDeProfesoresToolStripMenuItem.Text = "Lista de Profesores";
            listaDeProfesoresToolStripMenuItem.Click += listaDeProfesoresToolStripMenuItem_Click;
            // 
            // listadoDeDeportesToolStripMenuItem
            // 
            listadoDeDeportesToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listadoDeDeportesToolStripMenuItem.Name = "listadoDeDeportesToolStripMenuItem";
            listadoDeDeportesToolStripMenuItem.Size = new Size(137, 20);
            listadoDeDeportesToolStripMenuItem.Text = "Listado de Deportes";
            listadoDeDeportesToolStripMenuItem.Click += listadoDeDeportesToolStripMenuItem_Click;
            // 
            // listadoDeProvinciasYSusLocadidaesToolStripMenuItem
            // 
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem.Name = "listadoDeProvinciasYSusLocadidaesToolStripMenuItem";
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem.Size = new Size(245, 20);
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem.Text = "Listado de Provincias y sus locadidaes";
            listadoDeProvinciasYSusLocadidaesToolStripMenuItem.Click += listadoDeProvinciasYSusLocadidaesToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(876, 507);
            Controls.Add(btnDeportista);
            Controls.Add(btnDeportes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMenu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDeportes;
        private FontAwesome.Sharp.IconButton btnDeportista;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem listadoDeDeportistasToolStripMenuItem;
        private ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem listadoDeDeportesToolStripMenuItem;
        private ToolStripMenuItem listadoDeProvinciasYSusLocadidaesToolStripMenuItem;
    }
}