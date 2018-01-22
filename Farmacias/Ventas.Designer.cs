namespace Farmacias
{
    partial class Ventas
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
            this.Empleado = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.labelNomFarma = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(717, 52);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(124, 17);
            this.Empleado.TabIndex = 6;
            this.Empleado.Text = "Panfila Malechota";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(717, 11);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(47, 17);
            this.fecha.TabIndex = 5;
            this.fecha.Text = "label1";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(717, 32);
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
            this.labelNomFarma.Location = new System.Drawing.Point(221, 11);
            this.labelNomFarma.Name = "labelNomFarma";
            this.labelNomFarma.Size = new System.Drawing.Size(315, 42);
            this.labelNomFarma.TabIndex = 100;
            this.labelNomFarma.Text = "Farmacias Roma";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFactura);
            this.panel2.Controls.Add(this.labelNomFarma);
            this.panel2.Controls.Add(this.Empleado);
            this.panel2.Controls.Add(this.fecha);
            this.panel2.Controls.Add(this.Hora);
            this.panel2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 78);
            this.panel2.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Factura";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(76, 9);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(88, 19);
            this.lblFactura.TabIndex = 7;
            this.lblFactura.Text = "i\'m a factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label7.Location = new System.Drawing.Point(4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label6.Location = new System.Drawing.Point(158, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label5.Location = new System.Drawing.Point(557, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            // 
            // NProducto
            // 
            this.NProducto.HeaderText = "Producto";
            this.NProducto.Name = "NProducto";
            this.NProducto.ReadOnly = true;
            // 
            // CanProducto
            // 
            this.CanProducto.HeaderText = "Cantidad";
            this.CanProducto.Name = "CanProducto";
            this.CanProducto.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label9.Location = new System.Drawing.Point(23, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "F1: Realizar venta!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label8.Location = new System.Drawing.Point(745, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.panel3.Location = new System.Drawing.Point(13, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 98);
            this.panel3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label10.Location = new System.Drawing.Point(620, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "F4: Cancelar";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.lblT.Location = new System.Drawing.Point(791, 37);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 19);
            this.lblT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "F3: Capturar receta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "F2: Consulta";
            // 
            // PrecioP
            // 
            this.PrecioP.HeaderText = "Precio";
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.ReadOnly = true;
            // 
            // IDF
            // 
            this.IDF.HeaderText = "Factura";
            this.IDF.Name = "IDF";
            this.IDF.ReadOnly = true;
            this.IDF.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PrecioU";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblP);
            this.panel4.Controls.Add(this.txtIP);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtCP);
            this.panel4.Controls.Add(this.txtNP);
            this.panel4.Controls.Add(this.dgVenta);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(892, 308);
            this.panel4.TabIndex = 102;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.lblP.Location = new System.Drawing.Point(792, 7);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 19);
            this.lblP.TabIndex = 12;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.txtIP.Location = new System.Drawing.Point(31, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 27);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.txtCP.Location = new System.Drawing.Point(625, 3);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 27);
            this.txtCP.TabIndex = 3;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtNP
            // 
            this.txtNP.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F);
            this.txtNP.Location = new System.Drawing.Point(228, 4);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(323, 27);
            this.txtNP.TabIndex = 2;
            // 
            // dgVenta
            // 
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDF,
            this.IDProducto,
            this.NProducto,
            this.CanProducto,
            this.PrecioP});
            this.dgVenta.Location = new System.Drawing.Point(3, 30);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            this.dgVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgVenta.Size = new System.Drawing.Size(886, 275);
            this.dgVenta.TabIndex = 104;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Hora;
        public System.Windows.Forms.Label labelNomFarma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCP;
        public System.Windows.Forms.TextBox txtNP;
        public System.Windows.Forms.DataGridView dgVenta;
        public System.Windows.Forms.TextBox txtIP;
        public System.Windows.Forms.Label lblT;
        public System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label label10;

    }
}