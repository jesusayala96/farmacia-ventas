namespace Farmacias
{
    partial class Forma_Consultas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Empleado = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.labelNomFarma = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupCEmp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxEmp = new System.Windows.Forms.TextBox();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.groupCInv = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxinv = new System.Windows.Forms.TextBox();
            this.cbxinv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridinv = new System.Windows.Forms.DataGridView();
            this.groupCProd = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxbusqpd = new System.Windows.Forms.TextBox();
            this.cbxbpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridpd = new System.Windows.Forms.DataGridView();
            this.groupCProv = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbxbpv = new System.Windows.Forms.TextBox();
            this.cbxbpv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridpv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupCEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            this.groupCInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinv)).BeginInit();
            this.groupCProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).BeginInit();
            this.groupCProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Empleado);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Controls.Add(this.labelNomFarma);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 93);
            this.panel1.TabIndex = 100;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(698, 60);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(124, 17);
            this.Empleado.TabIndex = 6;
            this.Empleado.Text = "Panfila Malechota";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(698, 19);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(47, 17);
            this.fecha.TabIndex = 5;
            this.fecha.Text = "label1";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(698, 40);
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
            this.labelNomFarma.Location = new System.Drawing.Point(165, 15);
            this.labelNomFarma.Name = "labelNomFarma";
            this.labelNomFarma.Size = new System.Drawing.Size(315, 42);
            this.labelNomFarma.TabIndex = 50;
            this.labelNomFarma.Text = "Farmacias Roma";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupCEmp
            // 
            this.groupCEmp.BackColor = System.Drawing.Color.White;
            this.groupCEmp.Controls.Add(this.button1);
            this.groupCEmp.Controls.Add(this.tbxEmp);
            this.groupCEmp.Controls.Add(this.cbxEmp);
            this.groupCEmp.Controls.Add(this.label1);
            this.groupCEmp.Controls.Add(this.dataGridEmp);
            this.groupCEmp.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCEmp.Location = new System.Drawing.Point(8, 113);
            this.groupCEmp.Name = "groupCEmp";
            this.groupCEmp.Size = new System.Drawing.Size(890, 350);
            this.groupCEmp.TabIndex = 102;
            this.groupCEmp.TabStop = false;
            this.groupCEmp.Text = "Consulta de empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxEmp
            // 
            this.tbxEmp.Location = new System.Drawing.Point(123, 64);
            this.tbxEmp.Name = "tbxEmp";
            this.tbxEmp.Size = new System.Drawing.Size(186, 27);
            this.tbxEmp.TabIndex = 2;
            // 
            // cbxEmp
            // 
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(240, 30);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(121, 27);
            this.cbxEmp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.GridColor = System.Drawing.Color.DimGray;
            this.dataGridEmp.Location = new System.Drawing.Point(73, 105);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.Size = new System.Drawing.Size(777, 216);
            this.dataGridEmp.TabIndex = 5;
            // 
            // groupCInv
            // 
            this.groupCInv.BackColor = System.Drawing.Color.White;
            this.groupCInv.Controls.Add(this.button2);
            this.groupCInv.Controls.Add(this.tbxinv);
            this.groupCInv.Controls.Add(this.cbxinv);
            this.groupCInv.Controls.Add(this.label2);
            this.groupCInv.Controls.Add(this.dataGridinv);
            this.groupCInv.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCInv.Location = new System.Drawing.Point(8, 113);
            this.groupCInv.Name = "groupCInv";
            this.groupCInv.Size = new System.Drawing.Size(890, 350);
            this.groupCInv.TabIndex = 101;
            this.groupCInv.TabStop = false;
            this.groupCInv.Text = "Consulta de inventario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxinv
            // 
            this.tbxinv.Location = new System.Drawing.Point(123, 64);
            this.tbxinv.Name = "tbxinv";
            this.tbxinv.Size = new System.Drawing.Size(186, 27);
            this.tbxinv.TabIndex = 2;
            // 
            // cbxinv
            // 
            this.cbxinv.FormattingEnabled = true;
            this.cbxinv.Location = new System.Drawing.Point(240, 30);
            this.cbxinv.Name = "cbxinv";
            this.cbxinv.Size = new System.Drawing.Size(121, 27);
            this.cbxinv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridinv
            // 
            this.dataGridinv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridinv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridinv.GridColor = System.Drawing.Color.DimGray;
            this.dataGridinv.Location = new System.Drawing.Point(73, 105);
            this.dataGridinv.Name = "dataGridinv";
            this.dataGridinv.Size = new System.Drawing.Size(777, 216);
            this.dataGridinv.TabIndex = 5;
            // 
            // groupCProd
            // 
            this.groupCProd.BackColor = System.Drawing.Color.White;
            this.groupCProd.Controls.Add(this.button3);
            this.groupCProd.Controls.Add(this.tbxbusqpd);
            this.groupCProd.Controls.Add(this.cbxbpd);
            this.groupCProd.Controls.Add(this.label3);
            this.groupCProd.Controls.Add(this.dataGridpd);
            this.groupCProd.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProd.Location = new System.Drawing.Point(8, 113);
            this.groupCProd.Name = "groupCProd";
            this.groupCProd.Size = new System.Drawing.Size(890, 350);
            this.groupCProd.TabIndex = 101;
            this.groupCProd.TabStop = false;
            this.groupCProd.Text = "Consulta de productos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.dataGridpd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpd.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpd.Location = new System.Drawing.Point(73, 105);
            this.dataGridpd.Name = "dataGridpd";
            this.dataGridpd.Size = new System.Drawing.Size(777, 216);
            this.dataGridpd.TabIndex = 5;
            // 
            // groupCProv
            // 
            this.groupCProv.BackColor = System.Drawing.Color.White;
            this.groupCProv.Controls.Add(this.button4);
            this.groupCProv.Controls.Add(this.tbxbpv);
            this.groupCProv.Controls.Add(this.cbxbpv);
            this.groupCProv.Controls.Add(this.label4);
            this.groupCProv.Controls.Add(this.dataGridpv);
            this.groupCProv.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProv.Location = new System.Drawing.Point(8, 113);
            this.groupCProv.Name = "groupCProv";
            this.groupCProv.Size = new System.Drawing.Size(890, 350);
            this.groupCProv.TabIndex = 105;
            this.groupCProv.TabStop = false;
            this.groupCProv.Text = "Consulta de proveedores";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbxbpv
            // 
            this.tbxbpv.Location = new System.Drawing.Point(123, 64);
            this.tbxbpv.Name = "tbxbpv";
            this.tbxbpv.Size = new System.Drawing.Size(186, 27);
            this.tbxbpv.TabIndex = 2;
            // 
            // cbxbpv
            // 
            this.cbxbpv.FormattingEnabled = true;
            this.cbxbpv.Location = new System.Drawing.Point(240, 30);
            this.cbxbpv.Name = "cbxbpv";
            this.cbxbpv.Size = new System.Drawing.Size(121, 27);
            this.cbxbpv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridpv
            // 
            this.dataGridpv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpv.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpv.Location = new System.Drawing.Point(73, 105);
            this.dataGridpv.Name = "dataGridpv";
            this.dataGridpv.Size = new System.Drawing.Size(777, 216);
            this.dataGridpv.TabIndex = 5;
            // 
            // Forma_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCProd);
            this.Controls.Add(this.groupCInv);
            this.Controls.Add(this.groupCEmp);
            this.Controls.Add(this.groupCProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forma_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Forma_Consultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCEmp.ResumeLayout(false);
            this.groupCEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            this.groupCInv.ResumeLayout(false);
            this.groupCInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinv)).EndInit();
            this.groupCProd.ResumeLayout(false);
            this.groupCProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).EndInit();
            this.groupCProv.ResumeLayout(false);
            this.groupCProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label labelNomFarma;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.GroupBox groupCEmp;
        public System.Windows.Forms.GroupBox groupCInv;
        public System.Windows.Forms.GroupBox groupCProd;
        public System.Windows.Forms.GroupBox groupCProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxinv;
        private System.Windows.Forms.ComboBox cbxinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxbusqpd;
        private System.Windows.Forms.ComboBox cbxbpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbxbpv;
        private System.Windows.Forms.ComboBox cbxbpv;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridEmp;
        public System.Windows.Forms.ComboBox cbxEmp;
        public System.Windows.Forms.DataGridView dataGridpd;
        public System.Windows.Forms.DataGridView dataGridpv;
        public System.Windows.Forms.DataGridView dataGridinv;
    }
}