namespace SistemaAlmacen
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.entrar = new System.Windows.Forms.Button();
            this.contraseñatxtbx = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.usuariotxbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sistema_almacen = new System.Windows.Forms.Label();
            this.cacelarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(659, 422);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(299, 65);
            this.entrar.TabIndex = 3;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // contraseñatxtbx
            // 
            this.contraseñatxtbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contraseñatxtbx.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñatxtbx.Location = new System.Drawing.Point(720, 293);
            this.contraseñatxtbx.MaxLength = 15;
            this.contraseñatxtbx.Name = "contraseñatxtbx";
            this.contraseñatxtbx.Size = new System.Drawing.Size(271, 54);
            this.contraseñatxtbx.TabIndex = 2;
            this.contraseñatxtbx.UseSystemPasswordChar = true;
            this.contraseñatxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseñatxtbx_KeyPress);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(487, 145);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(161, 50);
            this.usuario.TabIndex = 5;
            this.usuario.Text = "Usuario:";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(487, 293);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(226, 50);
            this.contraseña.TabIndex = 6;
            this.contraseña.Text = "Contraseña:";
            // 
            // usuariotxbx
            // 
            this.usuariotxbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuariotxbx.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotxbx.Location = new System.Drawing.Point(720, 145);
            this.usuariotxbx.MaxLength = 15;
            this.usuariotxbx.Name = "usuariotxbx";
            this.usuariotxbx.Size = new System.Drawing.Size(271, 54);
            this.usuariotxbx.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.sistema_almacen);
            this.groupBox1.Location = new System.Drawing.Point(-6, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // sistema_almacen
            // 
            this.sistema_almacen.AutoSize = true;
            this.sistema_almacen.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema_almacen.Location = new System.Drawing.Point(259, 25);
            this.sistema_almacen.Name = "sistema_almacen";
            this.sistema_almacen.Size = new System.Drawing.Size(721, 64);
            this.sistema_almacen.TabIndex = 0;
            this.sistema_almacen.Text = "Sitema de almacen C. S. Jaguar";
            // 
            // cacelarbtn
            // 
            this.cacelarbtn.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacelarbtn.Location = new System.Drawing.Point(287, 422);
            this.cacelarbtn.Name = "cacelarbtn";
            this.cacelarbtn.Size = new System.Drawing.Size(299, 65);
            this.cacelarbtn.TabIndex = 4;
            this.cacelarbtn.Text = "Cancelar";
            this.cacelarbtn.UseVisualStyleBackColor = true;
            this.cacelarbtn.Click += new System.EventHandler(this.cacelarbtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1231, 535);
            this.Controls.Add(this.cacelarbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usuariotxbx);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.contraseñatxtbx);
            this.Controls.Add(this.entrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1247, 574);
            this.MinimumSize = new System.Drawing.Size(1247, 574);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE ALMACEN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox contraseñatxtbx;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox usuariotxbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sistema_almacen;
        private System.Windows.Forms.Button cacelarbtn;
    }
}

