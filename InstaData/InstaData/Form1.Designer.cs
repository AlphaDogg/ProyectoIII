namespace InstaData
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Teal;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrar.Location = new System.Drawing.Point(43, 346);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(206, 56);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxUsuario.Location = new System.Drawing.Point(43, 218);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(206, 28);
            this.txtBoxUsuario.TabIndex = 1;
            this.txtBoxUsuario.Text = "Usuario";
            this.txtBoxUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txtBoxUsuario.Leave += new System.EventHandler(this.txtBoxUsuario_Leave);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxPass.Location = new System.Drawing.Point(43, 250);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPass.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(206, 30);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.Text = "Contraseña";
            this.txtBoxPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.txtBoxPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(295, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstaData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

