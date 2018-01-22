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
    public partial class Forma_Consultas : Form
    {
        //nomb, idsuc, idemp, idal,nomfar
        //nomb, idsuc, idemp, idal, nomfar
        string nombemp, idsucursal, idempleado, idalmacen, nomfarmacia;
        public Forma_Consultas()
        {
            InitializeComponent();
        }
        public Forma_Consultas(string a, string b, string c, string d, string e)
        {
            nombemp = a; idsucursal = b; idempleado = c; idalmacen = d; nomfarmacia = e;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Forma_Consultas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cbxEmp.Items.Clear();
            cbxEmp.Items.Add("Nombre");
            cbxEmp.Items.Add("Número");
            cbxEmp.Items.Add("Todos");//if si se seleccion inhabilitar el texbox de busqueda
            cbxbpd.Items.Add("Número");
            cbxbpd.Items.Add("Nombre");
            cbxbpv.Items.Add("Número");
            cbxbpv.Items.Add("Nombre");
            cbxinv.Items.Add("Número");
            cbxinv.Items.Add("Nombre");
            cbxinv.Items.Add("Todos");//if si se seleccion inhabilitar el texbox de busqueda
            Empleado.Text = nombemp;
            
            labelNomFarma.Text = nomfarmacia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connections cx = new Connections(this);
            cx.ConsulEm(tbxEmp.Text,cbxEmp.Text,idsucursal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connections cx = new Connections(this);
            cx.ConsulPd(tbxbusqpd.Text,cbxbpd.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connections cx = new Connections(this);
            cx.ConsulPv(tbxbpv.Text, cbxbpv.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connections cx = new Connections(this);
            cx.ConsulInv(tbxinv.Text, cbxinv.Text,idalmacen);
        }
        
    }
}
