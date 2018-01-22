namespace Farmacias
{
    partial class ConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.groupCProd = new System.Windows.Forms.GroupBox();
            this.btnBP = new System.Windows.Forms.Button();
            this.tbxbusqpd = new System.Windows.Forms.TextBox();
            this.cbxbpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridpd = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupCProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCProd
            // 
            this.groupCProd.BackColor = System.Drawing.Color.White;
            this.groupCProd.Controls.Add(this.btnBP);
            this.groupCProd.Controls.Add(this.tbxbusqpd);
            this.groupCProd.Controls.Add(this.cbxbpd);
            this.groupCProd.Controls.Add(this.label3);
            this.groupCProd.Controls.Add(this.dataGridpd);
            this.groupCProd.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProd.Location = new System.Drawing.Point(12, 12);
            this.groupCProd.Name = "groupCProd";
            this.groupCProd.Size = new System.Drawing.Size(787, 347);
            this.groupCProd.TabIndex = 5;
            this.groupCProd.TabStop = false;
            this.groupCProd.Text = "Consulta de productos";
            // 
            // btnBP
            // 
            this.btnBP.Location = new System.Drawing.Point(324, 61);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(90, 34);
            this.btnBP.TabIndex = 3;
            this.btnBP.Text = "Buscar";
            this.btnBP.UseVisualStyleBackColor = true;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // tbxbusqpd
            // 
            this.tbxbusqpd.Location = new System.Drawing.Point(123, 64);
            this.tbxbusqpd.Name = "tbxbusqpd";
            this.tbxbusqpd.Size = new System.Drawing.Size(186, 27);
            this.tbxbusqpd.TabIndex = 2;
            // 
            // cbxbpd
            // 
            this.cbxbpd.FormattingEnabled = true;
            this.cbxbpd.Location = new System.Drawing.Point(240, 30);
            this.cbxbpd.Name = "cbxbpd";
            this.cbxbpd.Size = new System.Drawing.Size(121, 27);
            this.cbxbpd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridpd
            // 
            this.dataGridpd.AllowUserToAddRows = false;
            this.dataGridpd.AllowUserToDeleteRows = false;
            this.dataGridpd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpd.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpd.Location = new System.Drawing.Point(0, 101);
            this.dataGridpd.Name = "dataGridpd";
            this.dataGridpd.ReadOnly = true;
            this.dataGridpd.Size = new System.Drawing.Size(777, 216);
            this.dataGridpd.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 359);
            this.Controls.Add(this.groupCProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaVentas";
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            this.groupCProd.ResumeLayout(false);
            this.groupCProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupCProd;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.TextBox tbxbusqpd;
        private System.Windows.Forms.ComboBox cbxbpd;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridpd;
        private System.Windows.Forms.Timer timer1;
    }
}