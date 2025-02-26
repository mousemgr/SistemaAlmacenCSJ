﻿namespace SistemaAlmacen
{
    partial class InventarioAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioAlmacen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inventariolb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.salir = new System.Windows.Forms.Button();
            this.clientelb = new System.Windows.Forms.Label();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbxsumpeso = new System.Windows.Forms.TextBox();
            this.totalpesolb = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.inventariolb);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePickerFin);
            this.groupBox1.Controls.Add(this.dateTimePickerInicio);
            this.groupBox1.Location = new System.Drawing.Point(-6, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1623, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // inventariolb
            // 
            this.inventariolb.AutoSize = true;
            this.inventariolb.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariolb.Location = new System.Drawing.Point(469, 18);
            this.inventariolb.Name = "inventariolb";
            this.inventariolb.Size = new System.Drawing.Size(441, 64);
            this.inventariolb.TabIndex = 0;
            this.inventariolb.Text = "Inventario Almacen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(79, 50);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Visible = false;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(187, 41);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(36, 36);
            this.dateTimePickerFin.TabIndex = 33;
            this.dateTimePickerFin.Visible = false;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(134, 41);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(47, 36);
            this.dateTimePickerInicio.TabIndex = 32;
            this.dateTimePickerInicio.Visible = false;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(979, 101);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(164, 54);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // clientelb
            // 
            this.clientelb.AutoSize = true;
            this.clientelb.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelb.Location = new System.Drawing.Point(204, 109);
            this.clientelb.Name = "clientelb";
            this.clientelb.Size = new System.Drawing.Size(114, 39);
            this.clientelb.TabIndex = 29;
            this.clientelb.Text = "Cliente:";
            // 
            // cbxcliente
            // 
            this.cbxcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcliente.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(320, 105);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(233, 47);
            this.cbxcliente.TabIndex = 28;
            this.cbxcliente.SelectedIndexChanged += new System.EventHandler(this.cbxcliente_SelectedIndexChanged);
            // 
            // tbxsumpeso
            // 
            this.tbxsumpeso.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsumpeso.Location = new System.Drawing.Point(792, 106);
            this.tbxsumpeso.MaxLength = 15;
            this.tbxsumpeso.Name = "tbxsumpeso";
            this.tbxsumpeso.ReadOnly = true;
            this.tbxsumpeso.Size = new System.Drawing.Size(160, 46);
            this.tbxsumpeso.TabIndex = 36;
            // 
            // totalpesolb
            // 
            this.totalpesolb.AutoSize = true;
            this.totalpesolb.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpesolb.Location = new System.Drawing.Point(563, 109);
            this.totalpesolb.Name = "totalpesolb";
            this.totalpesolb.Size = new System.Drawing.Size(232, 39);
            this.totalpesolb.TabIndex = 35;
            this.totalpesolb.Text = "Total Peso Neto:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 170);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1326, 547);
            this.crystalReportViewer1.TabIndex = 37;
            // 
            // InventarioAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.tbxsumpeso);
            this.Controls.Add(this.totalpesolb);
            this.Controls.Add(this.clientelb);
            this.Controls.Add(this.cbxcliente);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "InventarioAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Almacen";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventarioAlmacen_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label inventariolb;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label clientelb;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbxsumpeso;
        private System.Windows.Forms.Label totalpesolb;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}