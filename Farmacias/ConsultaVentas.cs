using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Farmacias
{
    public partial class ConsultaVentas : Form
    {
        string nombemp, idsucursal, idempleado, idalmacen, nomfarmacia;
        public ConsultaVentas()
        {
            InitializeComponent();
        }
        public ConsultaVentas(string a, string b, string c, string d, string e)
        {
            nombemp = a; idsucursal = b; idempleado = c; idalmacen = d; nomfarmacia = e;
            InitializeComponent();
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            Connections cx = new Connections(this);
            cx.ConsulPro(tbxbusqpd.Text, cbxbpd.Text);
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cbxbpd.Items.Add("Número");
            cbxbpd.Items.Add("Nombre");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
