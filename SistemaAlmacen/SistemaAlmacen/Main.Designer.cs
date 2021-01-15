namespace SistemaAlmacen
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rECIBOALMACENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMBARQUEALMACENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOALMACENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Unicode MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.rECIBOALMACENToolStripMenuItem,
            this.eMBARQUEALMACENToolStripMenuItem,
            this.iNVENTARIOALMACENToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 50);
            // 
            // rECIBOALMACENToolStripMenuItem
            // 
            this.rECIBOALMACENToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.rECIBOALMACENToolStripMenuItem.Name = "rECIBOALMACENToolStripMenuItem";
            this.rECIBOALMACENToolStripMenuItem.Size = new System.Drawing.Size(342, 50);
            this.rECIBOALMACENToolStripMenuItem.Text = "RECIBO ALMACEN";
            this.rECIBOALMACENToolStripMenuItem.Click += new System.EventHandler(this.rECIBOALMACENToolStripMenuItem_Click);
            // 
            // eMBARQUEALMACENToolStripMenuItem
            // 
            this.eMBARQUEALMACENToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.eMBARQUEALMACENToolStripMenuItem.Name = "eMBARQUEALMACENToolStripMenuItem";
            this.eMBARQUEALMACENToolStripMenuItem.Size = new System.Drawing.Size(407, 50);
            this.eMBARQUEALMACENToolStripMenuItem.Text = "EMBARQUE ALMACEN";
            this.eMBARQUEALMACENToolStripMenuItem.Click += new System.EventHandler(this.eMBARQUEALMACENToolStripMenuItem_Click);
            // 
            // iNVENTARIOALMACENToolStripMenuItem
            // 
            this.iNVENTARIOALMACENToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.iNVENTARIOALMACENToolStripMenuItem.Name = "iNVENTARIOALMACENToolStripMenuItem";
            this.iNVENTARIOALMACENToolStripMenuItem.Size = new System.Drawing.Size(421, 50);
            this.iNVENTARIOALMACENToolStripMenuItem.Text = "INVENTARIO ALMACEN";
            this.iNVENTARIOALMACENToolStripMenuItem.Click += new System.EventHandler(this.iNVENTARIOALMACENToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(132, 50);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1604, 804);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rECIBOALMACENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMBARQUEALMACENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOALMACENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}