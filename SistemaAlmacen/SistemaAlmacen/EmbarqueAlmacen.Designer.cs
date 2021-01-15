namespace SistemaAlmacen
{
    partial class EmbarqueAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbarqueAlmacen));
            this.salirbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.embarquealmacenlb = new System.Windows.Forms.Label();
            this.generarremisionbtn = new System.Windows.Forms.Button();
            this.cargarbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventariolb = new System.Windows.Forms.Label();
            this.clientelb = new System.Windows.Forms.Label();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.origentbx = new System.Windows.Forms.TextBox();
            this.origenlb = new System.Windows.Forms.Label();
            this.remisionlb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fechaembarquelb = new System.Windows.Forms.Label();
            this.cargarrollolb = new System.Windows.Forms.Label();
            this.cargarrollobtn = new System.Windows.Forms.Button();
            this.regresarrollobtn = new System.Windows.Forms.Button();
            this.regresarrollolb = new System.Windows.Forms.Label();
            this.embarquelb = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numremisiontbx = new System.Windows.Forms.TextBox();
            this.lotejagtbx = new System.Windows.Forms.TextBox();
            this.lotejagregresotbx = new System.Windows.Forms.TextBox();
            this.verembarquesbtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buscarrollolb = new System.Windows.Forms.Label();
            this.lotedelclientetbx = new System.Windows.Forms.TextBox();
            this.lotedelclientelb = new System.Windows.Forms.Label();
            this.LBTransportista = new System.Windows.Forms.Label();
            this.TxbTrannsportista = new System.Windows.Forms.TextBox();
            this.TbxDestino = new System.Windows.Forms.TextBox();
            this.LbDestino = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // salirbtn
            // 
            this.salirbtn.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirbtn.Location = new System.Drawing.Point(95, 659);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(262, 55);
            this.salirbtn.TabIndex = 16;
            this.salirbtn.Text = "Salir";
            this.salirbtn.UseVisualStyleBackColor = true;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.embarquealmacenlb);
            this.groupBox1.Location = new System.Drawing.Point(-3, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1603, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // embarquealmacenlb
            // 
            this.embarquealmacenlb.AutoSize = true;
            this.embarquealmacenlb.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embarquealmacenlb.Location = new System.Drawing.Point(490, 28);
            this.embarquealmacenlb.Name = "embarquealmacenlb";
            this.embarquealmacenlb.Size = new System.Drawing.Size(351, 50);
            this.embarquealmacenlb.TabIndex = 2;
            this.embarquealmacenlb.Text = "Embarque Almacen";
            // 
            // generarremisionbtn
            // 
            this.generarremisionbtn.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarremisionbtn.Location = new System.Drawing.Point(989, 660);
            this.generarremisionbtn.Name = "generarremisionbtn";
            this.generarremisionbtn.Size = new System.Drawing.Size(262, 55);
            this.generarremisionbtn.TabIndex = 18;
            this.generarremisionbtn.Text = "Generar Remision";
            this.generarremisionbtn.UseVisualStyleBackColor = true;
            this.generarremisionbtn.Click += new System.EventHandler(this.generarremisionbtn_Click);
            // 
            // cargarbtn
            // 
            this.cargarbtn.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarbtn.Location = new System.Drawing.Point(390, 659);
            this.cargarbtn.Name = "cargarbtn";
            this.cargarbtn.Size = new System.Drawing.Size(262, 55);
            this.cargarbtn.TabIndex = 19;
            this.cargarbtn.Text = "Finalizar Embarque";
            this.cargarbtn.UseVisualStyleBackColor = true;
            this.cargarbtn.Click += new System.EventHandler(this.cargarbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 388);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // inventariolb
            // 
            this.inventariolb.AutoSize = true;
            this.inventariolb.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariolb.Location = new System.Drawing.Point(131, 95);
            this.inventariolb.Name = "inventariolb";
            this.inventariolb.Size = new System.Drawing.Size(144, 39);
            this.inventariolb.TabIndex = 21;
            this.inventariolb.Text = "Inventario";
            // 
            // clientelb
            // 
            this.clientelb.AutoSize = true;
            this.clientelb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelb.Location = new System.Drawing.Point(397, 104);
            this.clientelb.Name = "clientelb";
            this.clientelb.Size = new System.Drawing.Size(83, 28);
            this.clientelb.TabIndex = 31;
            this.clientelb.Text = "Cliente:";
            // 
            // cbxcliente
            // 
            this.cbxcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcliente.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(486, 101);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(185, 36);
            this.cbxcliente.TabIndex = 30;
            this.cbxcliente.SelectedIndexChanged += new System.EventHandler(this.cbxcliente_SelectedIndexChanged);
            // 
            // origentbx
            // 
            this.origentbx.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origentbx.Location = new System.Drawing.Point(766, 101);
            this.origentbx.MaxLength = 20;
            this.origentbx.Name = "origentbx";
            this.origentbx.ReadOnly = true;
            this.origentbx.Size = new System.Drawing.Size(164, 36);
            this.origentbx.TabIndex = 32;
            this.origentbx.Text = "Jaguar Irapuato";
            // 
            // origenlb
            // 
            this.origenlb.AutoSize = true;
            this.origenlb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origenlb.Location = new System.Drawing.Point(679, 104);
            this.origenlb.Name = "origenlb";
            this.origenlb.Size = new System.Drawing.Size(81, 28);
            this.origenlb.TabIndex = 33;
            this.origenlb.Text = "Origen:";
            // 
            // remisionlb
            // 
            this.remisionlb.AutoSize = true;
            this.remisionlb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remisionlb.Location = new System.Drawing.Point(488, 166);
            this.remisionlb.Name = "remisionlb";
            this.remisionlb.Size = new System.Drawing.Size(232, 28);
            this.remisionlb.TabIndex = 35;
            this.remisionlb.Text = "Num. Remision: JAG-R";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(678, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 36);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // fechaembarquelb
            // 
            this.fechaembarquelb.AutoSize = true;
            this.fechaembarquelb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaembarquelb.Location = new System.Drawing.Point(463, 233);
            this.fechaembarquelb.Name = "fechaembarquelb";
            this.fechaembarquelb.Size = new System.Drawing.Size(211, 28);
            this.fechaembarquelb.TabIndex = 36;
            this.fechaembarquelb.Text = "Fecha de embarque:";
            // 
            // cargarrollolb
            // 
            this.cargarrollolb.AutoSize = true;
            this.cargarrollolb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarrollolb.Location = new System.Drawing.Point(549, 428);
            this.cargarrollolb.Name = "cargarrollolb";
            this.cargarrollolb.Size = new System.Drawing.Size(257, 28);
            this.cargarrollolb.TabIndex = 38;
            this.cargarrollolb.Text = "Cargar Rollo al Embarque";
            // 
            // cargarrollobtn
            // 
            this.cargarrollobtn.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarrollobtn.Location = new System.Drawing.Point(639, 457);
            this.cargarrollobtn.Name = "cargarrollobtn";
            this.cargarrollobtn.Size = new System.Drawing.Size(86, 51);
            this.cargarrollobtn.TabIndex = 39;
            this.cargarrollobtn.Text = ">";
            this.cargarrollobtn.UseVisualStyleBackColor = true;
            this.cargarrollobtn.Click += new System.EventHandler(this.cargarrollobtn_Click);
            // 
            // regresarrollobtn
            // 
            this.regresarrollobtn.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarrollobtn.Location = new System.Drawing.Point(639, 547);
            this.regresarrollobtn.Name = "regresarrollobtn";
            this.regresarrollobtn.Size = new System.Drawing.Size(86, 51);
            this.regresarrollobtn.TabIndex = 41;
            this.regresarrollobtn.Text = "<";
            this.regresarrollobtn.UseVisualStyleBackColor = true;
            this.regresarrollobtn.Click += new System.EventHandler(this.regresarrollobtn_Click);
            // 
            // regresarrollolb
            // 
            this.regresarrollolb.AutoSize = true;
            this.regresarrollolb.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarrollolb.Location = new System.Drawing.Point(543, 516);
            this.regresarrollolb.Name = "regresarrollolb";
            this.regresarrollolb.Size = new System.Drawing.Size(275, 28);
            this.regresarrollolb.TabIndex = 40;
            this.regresarrollolb.Text = "Regresar Rollo al Inventario";
            // 
            // embarquelb
            // 
            this.embarquelb.AutoSize = true;
            this.embarquelb.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embarquelb.Location = new System.Drawing.Point(1079, 95);
            this.embarquelb.Name = "embarquelb";
            this.embarquelb.Size = new System.Drawing.Size(150, 39);
            this.embarquelb.TabIndex = 43;
            this.embarquelb.Text = "Embarque";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(967, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(371, 497);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // numremisiontbx
            // 
            this.numremisiontbx.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numremisiontbx.Location = new System.Drawing.Point(726, 163);
            this.numremisiontbx.MaxLength = 10;
            this.numremisiontbx.Name = "numremisiontbx";
            this.numremisiontbx.Size = new System.Drawing.Size(145, 36);
            this.numremisiontbx.TabIndex = 44;
            this.numremisiontbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numremisiontbx_KeyPress);
            // 
            // lotejagtbx
            // 
            this.lotejagtbx.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotejagtbx.Location = new System.Drawing.Point(644, 613);
            this.lotejagtbx.MaxLength = 15;
            this.lotejagtbx.Name = "lotejagtbx";
            this.lotejagtbx.Size = new System.Drawing.Size(37, 29);
            this.lotejagtbx.TabIndex = 45;
            this.lotejagtbx.Visible = false;
            // 
            // lotejagregresotbx
            // 
            this.lotejagregresotbx.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotejagregresotbx.Location = new System.Drawing.Point(688, 613);
            this.lotejagregresotbx.MaxLength = 15;
            this.lotejagregresotbx.Name = "lotejagregresotbx";
            this.lotejagregresotbx.Size = new System.Drawing.Size(37, 29);
            this.lotejagregresotbx.TabIndex = 46;
            this.lotejagregresotbx.Visible = false;
            // 
            // verembarquesbtn
            // 
            this.verembarquesbtn.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verembarquesbtn.Location = new System.Drawing.Point(678, 659);
            this.verembarquesbtn.Name = "verembarquesbtn";
            this.verembarquesbtn.Size = new System.Drawing.Size(262, 55);
            this.verembarquesbtn.TabIndex = 47;
            this.verembarquesbtn.Text = "Ver Embarques";
            this.verembarquesbtn.UseVisualStyleBackColor = true;
            this.verembarquesbtn.Click += new System.EventHandler(this.verembarquesbtn_Click);
            // 
            // buscarrollolb
            // 
            this.buscarrollolb.AutoSize = true;
            this.buscarrollolb.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarrollolb.Location = new System.Drawing.Point(112, 145);
            this.buscarrollolb.Name = "buscarrollolb";
            this.buscarrollolb.Size = new System.Drawing.Size(173, 36);
            this.buscarrollolb.TabIndex = 50;
            this.buscarrollolb.Text = "Buscar rollos";
            // 
            // lotedelclientetbx
            // 
            this.lotedelclientetbx.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotedelclientetbx.Location = new System.Drawing.Point(238, 197);
            this.lotedelclientetbx.MaxLength = 15;
            this.lotedelclientetbx.Name = "lotedelclientetbx";
            this.lotedelclientetbx.Size = new System.Drawing.Size(145, 36);
            this.lotedelclientetbx.TabIndex = 52;
            this.lotedelclientetbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lotedelclientetbx_KeyUp);
            // 
            // lotedelclientelb
            // 
            this.lotedelclientelb.AutoSize = true;
            this.lotedelclientelb.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotedelclientelb.Location = new System.Drawing.Point(12, 202);
            this.lotedelclientelb.Name = "lotedelclientelb";
            this.lotedelclientelb.Size = new System.Drawing.Size(224, 25);
            this.lotedelclientelb.TabIndex = 51;
            this.lotedelclientelb.Text = "Lote interno o del cliente:";
            // 
            // LBTransportista
            // 
            this.LBTransportista.AutoSize = true;
            this.LBTransportista.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTransportista.Location = new System.Drawing.Point(445, 367);
            this.LBTransportista.Name = "LBTransportista";
            this.LBTransportista.Size = new System.Drawing.Size(143, 28);
            this.LBTransportista.TabIndex = 53;
            this.LBTransportista.Text = "Transportista:";
            // 
            // TxbTrannsportista
            // 
            this.TxbTrannsportista.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbTrannsportista.Location = new System.Drawing.Point(594, 364);
            this.TxbTrannsportista.MaxLength = 35;
            this.TxbTrannsportista.Name = "TxbTrannsportista";
            this.TxbTrannsportista.Size = new System.Drawing.Size(318, 36);
            this.TxbTrannsportista.TabIndex = 54;
            // 
            // TbxDestino
            // 
            this.TbxDestino.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDestino.Location = new System.Drawing.Point(678, 300);
            this.TbxDestino.MaxLength = 15;
            this.TbxDestino.Name = "TbxDestino";
            this.TbxDestino.Size = new System.Drawing.Size(177, 36);
            this.TbxDestino.TabIndex = 56;
            // 
            // LbDestino
            // 
            this.LbDestino.AutoSize = true;
            this.LbDestino.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDestino.Location = new System.Drawing.Point(529, 303);
            this.LbDestino.Name = "LbDestino";
            this.LbDestino.Size = new System.Drawing.Size(146, 28);
            this.LbDestino.TabIndex = 55;
            this.LbDestino.Text = "Embarcado a:";
            // 
            // EmbarqueAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.TbxDestino);
            this.Controls.Add(this.LbDestino);
            this.Controls.Add(this.TxbTrannsportista);
            this.Controls.Add(this.LBTransportista);
            this.Controls.Add(this.lotedelclientetbx);
            this.Controls.Add(this.lotedelclientelb);
            this.Controls.Add(this.buscarrollolb);
            this.Controls.Add(this.verembarquesbtn);
            this.Controls.Add(this.lotejagregresotbx);
            this.Controls.Add(this.lotejagtbx);
            this.Controls.Add(this.numremisiontbx);
            this.Controls.Add(this.embarquelb);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.regresarrollobtn);
            this.Controls.Add(this.regresarrollolb);
            this.Controls.Add(this.cargarrollobtn);
            this.Controls.Add(this.cargarrollolb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fechaembarquelb);
            this.Controls.Add(this.remisionlb);
            this.Controls.Add(this.origentbx);
            this.Controls.Add(this.origenlb);
            this.Controls.Add(this.clientelb);
            this.Controls.Add(this.cbxcliente);
            this.Controls.Add(this.inventariolb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cargarbtn);
            this.Controls.Add(this.generarremisionbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salirbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "EmbarqueAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salirbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generarremisionbtn;
        private System.Windows.Forms.Button cargarbtn;
        private System.Windows.Forms.Label embarquealmacenlb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label inventariolb;
        private System.Windows.Forms.Label clientelb;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.TextBox origentbx;
        private System.Windows.Forms.Label origenlb;
        private System.Windows.Forms.Label remisionlb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fechaembarquelb;
        private System.Windows.Forms.Label cargarrollolb;
        private System.Windows.Forms.Button cargarrollobtn;
        private System.Windows.Forms.Button regresarrollobtn;
        private System.Windows.Forms.Label regresarrollolb;
        private System.Windows.Forms.Label embarquelb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox numremisiontbx;
        private System.Windows.Forms.TextBox lotejagtbx;
        private System.Windows.Forms.TextBox lotejagregresotbx;
        private System.Windows.Forms.Button verembarquesbtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label buscarrollolb;
        private System.Windows.Forms.TextBox lotedelclientetbx;
        private System.Windows.Forms.Label lotedelclientelb;
        private System.Windows.Forms.Label LBTransportista;
        private System.Windows.Forms.TextBox TxbTrannsportista;
        private System.Windows.Forms.TextBox TbxDestino;
        private System.Windows.Forms.Label LbDestino;
    }
}