namespace Farmacias
{
    partial class GerenteVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenteVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Empleado = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.labelNomFarma = new System.Windows.Forms.Label();
            this.groupVT = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.datagridVT = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupVV = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVV = new System.Windows.Forms.Label();
            this.datagridVV = new System.Windows.Forms.DataGridView();
            this.groupVF = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVF = new System.Windows.Forms.Label();
            this.dataFecha = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVT)).BeginInit();
            this.groupVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVV)).BeginInit();
            this.groupVF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Empleado);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Controls.Add(this.labelNomFarma);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 93);
            this.panel1.TabIndex = 1;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(682, 65);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(124, 17);
            this.Empleado.TabIndex = 6;
            this.Empleado.Text = "Panfila Malechota";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(682, 24);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(47, 17);
            this.fecha.TabIndex = 5;
            this.fecha.Text = "label1";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(682, 45);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(47, 17);
            this.Hora.TabIndex = 4;
            this.Hora.Text = "label1";
            // 
            // labelNomFarma
            // 
            this.labelNomFarma.AutoSize = true;
            this.labelNomFarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomFarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNomFarma.Location = new System.Drawing.Point(171, 24);
            this.labelNomFarma.Name = "labelNomFarma";
            this.labelNomFarma.Size = new System.Drawing.Size(315, 42);
            this.labelNomFarma.TabIndex = 0;
            this.labelNomFarma.Text = "Farmacias Roma";
            // 
            // groupVT
            // 
            this.groupVT.Controls.Add(this.label2);
            this.groupVT.Controls.Add(this.lblVT);
            this.groupVT.Controls.Add(this.datagridVT);
            this.groupVT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVT.Location = new System.Drawing.Point(92, 102);
            this.groupVT.Name = "groupVT";
            this.groupVT.Size = new System.Drawing.Size(755, 350);
            this.groupVT.TabIndex = 3;
            this.groupVT.TabStop = false;
            this.groupVT.Text = "Ventas Totales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Location = new System.Drawing.Point(698, 328);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(51, 19);
            this.lblVT.TabIndex = 1;
            this.lblVT.Text = "$$$$$$$";
            // 
            // datagridVT
            // 
            this.datagridVT.BackgroundColor = System.Drawing.Color.White;
            this.datagridVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVT.GridColor = System.Drawing.SystemColors.ControlLight;
            this.datagridVT.Location = new System.Drawing.Point(6, 82);
            this.datagridVT.Name = "datagridVT";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridVT.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridVT.Size = new System.Drawing.Size(743, 230);
            this.datagridVT.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupVV
            // 
            this.groupVV.Controls.Add(this.label4);
            this.groupVV.Controls.Add(this.cbVendedor);
            this.groupVV.Controls.Add(this.label1);
            this.groupVV.Controls.Add(this.lblVV);
            this.groupVV.Controls.Add(this.datagridVV);
            this.groupVV.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVV.Location = new System.Drawing.Point(86, 102);
            this.groupVV.Name = "groupVV";
            this.groupVV.Size = new System.Drawing.Size(755, 350);
            this.groupVV.TabIndex = 4;
            this.groupVV.TabStop = false;
            this.groupVV.Text = "Ventas por Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendedor";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(84, 49);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(121, 27);
            this.cbVendedor.TabIndex = 1;
            this.cbVendedor.SelectedIndexChanged += new System.EventHandler(this.cbVendedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // lblVV
            // 
            this.lblVV.AutoSize = true;
            this.lblVV.Location = new System.Drawing.Point(698, 328);
            this.lblVV.Name = "lblVV";
            this.lblVV.Size = new System.Drawing.Size(51, 19);
            this.lblVV.TabIndex = 1;
            this.lblVV.Text = "$$$$$$$";
            // 
            // datagridVV
            // 
            this.datagridVV.BackgroundColor = System.Drawing.Color.White;
            this.datagridVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.datagridVV.Location = new System.Drawing.Point(6, 82);
            this.datagridVV.Name = "datagridVV";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.datagridVV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridVV.Size = new System.Drawing.Size(743, 230);
            this.datagridVV.TabIndex = 0;
            // 
            // groupVF
            // 
            this.groupVF.Controls.Add(this.cbMes);
            this.groupVF.Controls.Add(this.dtfecha);
            this.groupVF.Controls.Add(this.label5);
            this.groupVF.Controls.Add(this.cbTipo);
            this.groupVF.Controls.Add(this.label6);
            this.groupVF.Controls.Add(this.lblVF);
            this.groupVF.Controls.Add(this.dataFecha);
            this.groupVF.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupVF.Location = new System.Drawing.Point(80, 102);
            this.groupVF.Name = "groupVF";
            this.groupVF.Size = new System.Drawing.Size(755, 350);
            this.groupVF.TabIndex = 5;
            this.groupVF.TabStop = false;
            this.groupVF.Text = "Ventas por Fecha";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(177, 49);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 27);
            this.cbMes.TabIndex = 6;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(177, 49);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(105, 27);
            this.dtfecha.TabIndex = 5;
            this.dtfecha.Value = new System.DateTime(2016, 3, 31, 0, 0, 0, 0);
            this.dtfecha.ValueChanged += new System.EventHandler(this.dtfecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(50, 49);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 27);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Location = new System.Drawing.Point(698, 328);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(51, 19);
            this.lblVF.TabIndex = 1;
            this.lblVF.Text = "$$$$$$$";
            // 
            // dataFecha
            // 
            this.dataFecha.AllowUserToAddRows = false;
            this.dataFecha.AllowUserToDeleteRows = false;
            this.dataFecha.BackgroundColor = System.Drawing.Color.White;
            this.dataFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFecha.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataFecha.Location = new System.Drawing.Point(6, 82);
            this.dataFecha.Name = "dataFecha";
            this.dataFecha.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataFecha.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataFecha.Size = new System.Drawing.Size(743, 230);
            this.dataFecha.TabIndex = 0;
            // 
            // GerenteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupVF);
            this.Controls.Add(this.groupVV);
            this.Controls.Add(this.groupVT);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenteVentas";
            this.Load += new System.EventHandler(this.GerenteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupVT.ResumeLayout(false);
            this.groupVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVT)).EndInit();
            this.groupVV.ResumeLayout(false);
            this.groupVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVV)).EndInit();
            this.groupVF.ResumeLayout(false);
            this.groupVF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Hora;
        public System.Windows.Forms.Label labelNomFarma;
        public System.Windows.Forms.GroupBox groupVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView datagridVT;
        public System.Windows.Forms.Label lblVT;
        public System.Windows.Forms.GroupBox groupVV;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblVV;
        public System.Windows.Forms.DataGridView datagridVV;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox groupVF;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblVF;
        public System.Windows.Forms.DataGridView dataFecha;
        public System.Windows.Forms.DateTimePicker dtfecha;
        public System.Windows.Forms.ComboBox cbMes;
        public System.Windows.Forms.ComboBox cbVendedor;
    }
}