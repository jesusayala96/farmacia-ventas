using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacias
{
    public partial class GerenteVentas : Form
    {
        
        string nombemp, idsucursal, idempleado, idalmacen, nomfarmacia;
        Connections cx = new Connections();
        public GerenteVentas()
        {
            InitializeComponent();
        }
        public GerenteVentas(string a, string b, string c, string d, string e)
        {
            nombemp = a; idsucursal = b; idempleado = c; idalmacen = d; nomfarmacia = e;
            InitializeComponent();
            
        }

        private void GerenteVentas_Load(object sender, EventArgs e)
        {
            cx = new Connections(this);//aki es donde le mandas la info al constructor :p, solo ocupas invocar una vez
            cx.VentasTotales(int.Parse(idsucursal));//no deberia estar aki pero esta mejor que donde estaba >.<  igual si pero el total de la etiqueta lblVV esta cagando el palo
            cx.cbx1(idsucursal,idempleado);
            timer1.Start();
            Empleado.Text = nombemp;
            labelNomFarma.Text = nomfarmacia;
            cbTipo.Items.Add("Mes");
            cbTipo.Items.Add("Dia");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Connections cx = new Connections(this);
                cx.VentasVendedor(int.Parse(idsucursal), int.Parse(cbVendedor.Text));
            }
            catch { }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.Text == "Mes")
                {
                    dtfecha.Visible = false;
                    cbMes.Visible = true;
                    //Connections cx = new Connections(this);
                    cx.Meses();
                }
                else if (cbTipo.Text == "Dia")
                {
                    dtfecha.Visible = true;
                    cbMes.Visible = false;
                }
            }
            catch (Exception a) { MessageBox.Show(a.Message.ToString()); }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mes
            try
            {
                // Connections cx = new Connections(this);
                //cx.VentasMes(int.Parse(idsucursal), int.Parse(cbMes.SelectedValue.ToString()));*/
                Singleton.Instance.GetDBConnection().Open();

                SqlDataAdapter ada = new SqlDataAdapter(string.Format("select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura, empleados, sucursal where month(factura.fecha)={0} and empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={1}", int.Parse(cbMes.Text),int.Parse(idsucursal)), Singleton.Instance.GetDBConnection());
               DataSet dat = new DataSet();
                ada.Fill(dat, "Ventas Mes");
                dataFecha.DataSource = dat;
                dataFecha.DataMember = "Ventas Mes";
                Singleton.Instance.GetDBConnection().Close();

                int total = 0;
                foreach (DataGridViewRow Celda in dataFecha.Rows)
                {
                    total += int.Parse(Celda.Cells[2].Value.ToString());
                }
                lblVF.Text = total.ToString();
            }
            catch (Exception a) { MessageBox.Show(a.Message.ToString()); }
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            //dia
            try
            {
                //Connections cx = new Connections(this);
                Singleton.Instance.GetDBConnection().Open();
                SqlDataAdapter ada = new SqlDataAdapter(string.Format("select factura.idfactura, factura.fecha, factura.total, factura.idempleado from factura, empleados, sucursal where factura.fecha='{0}' and empleados.idempleado=factura.idempleado and empleados.idsucursal=sucursal.idsucursal and sucursal.idsucursal={1}", dtfecha.Value.ToShortDateString(), idsucursal), Singleton.Instance.GetDBConnection());
                DataSet dat = new DataSet();
                ada.Fill(dat, "Ventas Dia");
                dataFecha.DataSource = dat;
                dataFecha.DataMember = "Ventas Dia";
                Singleton.Instance.GetDBConnection().Close();

                int total = 0;
                foreach (DataGridViewRow Celda in datagridVT.Rows)
                {
                    total += int.Parse(Celda.Cells[2].Value.ToString());
                }
                lblVF.Text = total.ToString();
            }
            catch { }
        }
    }
}
