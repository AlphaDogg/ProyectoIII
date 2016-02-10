namespace InstaData
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacturar
            // 
            resources.ApplyResources(this.btnFacturar, "btnFacturar");
            this.btnFacturar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFacturar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturar.Image = global::InstaData.Properties.Resources.invoice;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnMantenimiento
            // 
            resources.ApplyResources(this.btnMantenimiento, "btnMantenimiento");
            this.btnMantenimiento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMantenimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMantenimiento.Image = global::InstaData.Properties.Resources.settings;
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnReportes
            // 
            resources.ApplyResources(this.btnReportes, "btnReportes");
            this.btnReportes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Image = global::InstaData.Properties.Resources.statistics;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnExtras
            // 
            resources.ApplyResources(this.btnExtras, "btnExtras");
            this.btnExtras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtras.Image = global::InstaData.Properties.Resources.config;
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.UseVisualStyleBackColor = false;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            resources.ApplyResources(this.usuarioToolStripMenuItem, "usuarioToolStripMenuItem");
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.finalizarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = global::InstaData.Properties.Resources.user;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Image = global::InstaData.Properties.Resources.my_account;
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            resources.ApplyResources(this.informacionToolStripMenuItem, "informacionToolStripMenuItem");
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // finalizarSesionToolStripMenuItem
            // 
            this.finalizarSesionToolStripMenuItem.Image = global::InstaData.Properties.Resources.logout;
            this.finalizarSesionToolStripMenuItem.Name = "finalizarSesionToolStripMenuItem";
            resources.ApplyResources(this.finalizarSesionToolStripMenuItem, "finalizarSesionToolStripMenuItem");
            this.finalizarSesionToolStripMenuItem.Click += new System.EventHandler(this.finalizarSesionToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InstaData.Properties.Resources.background_solid_line_cell_bright_hogh_contrast_hd_wallpaper_49840;
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}