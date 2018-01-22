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
    public partial class Ventas : Form
    {
        string nmbre, ids, ide, ida, nmbref;
        int numF;
        public int total;
        public Ventas()
        { InitializeComponent(); }
        //nombre, idsucursal, idempleado, idalmacen, nombrefar
        public Ventas(string a, string b, string c, string d, string e)
        {
            nmbre = a; ids = b; ide = c; ida = d; nmbref = e;
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToShortDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
            lblFactura.Text = numF.ToString();
            lblT.Text = total.ToString();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Connections cx = new Connections(this);
            numF = cx.NumeroFactura();
            Empleado.Text = nmbre;
            labelNomFarma.Text = nmbref;
            txtIP.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.Focused)
                return base.ProcessCmdKey(ref msg, keyData);
            if ((keyData != Keys.F1) & (keyData != Keys.F2) & (keyData != Keys.F3) & (keyData != Keys.F4))
                return base.ProcessCmdKey(ref msg, keyData);
            try
            {
                switch (keyData)
                {
                    case Keys.F1:
                        Connections cx = new Connections(this);
                        //nombre, idsucursal, idempleado, idalmacen, nombrefar
                        cx.GuardarFactura(numF, fecha.Text, total, ide);
                        cx.GuardarDetalleFactura(ida);
                        numF = cx.NumeroFactura();
                        MessageBox.Show("Venta Realizada!");
                        Limpiar L = new Limpiar(this);
                        L.Facturas();
                        total = 0;//Cada vez que se realiza una venta todo debe quedar limpio cuando se agrega un producto al detalle de la venta los txbx deben quedar limpios
                        break;
                    case Keys.F2:
                        MessageBox.Show("Consulta");
                        ConsultaVentas nueva = new ConsultaVentas();
                        nueva.Show();
                        break;
                    case Keys.F3:
                        Receta Nueva = new Receta();
                        if (Nueva.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Receta Aceptada!");//Me quedo duda esto para que?
                        }

                        break;
                    case Keys.F4:
                        MessageBox.Show("Venta Cancelada");
                        Limpiar C = new Limpiar(this);
                        C.Facturas();
                        total = 0;
                        break;
                    default:
                        break;
                }
            }
            catch { MessageBox.Show("Error de validacion!"); }
            

            return true;
        }
        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connections cx = new Connections(this);
                cx.ActualizarTxt(txtIP.Text, ida);
            }
            catch { }

        }
        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//Presionar ENTER
            {
                Connections cx = new Connections(this);
                cx.AgregarProducto(numF, txtIP.Text, txtNP.Text, txtCP.Text, lblP.Text);
                cx.Total();
            }

        }

    }
}
