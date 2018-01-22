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
    public partial class Vendedor : Form
    {
        string nmbre, ids, ide, ida, nmbref;
        bool isopen, isopenv;
        Forma_Consultas fc;
        Ventas vf;
        public Vendedor(string a, string b, string c, string d, string e)
        {
            nmbre = a; ids = b; ide = c; ida = d; nmbref = e;
            InitializeComponent();
        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isopenv & !isopen)
                {
                    vf.Close();
                    isopenv = false;
                    fc = new Forma_Consultas(nmbre, ids, ide, ida, nmbref);
                    fc.MdiParent = this;
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCInv.Visible = true;
                    fc.Show();
                    isopen = true;
                }
                else if (isopen)
                {
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCInv.Visible = true;
                    fc.Update();
                }
                else
                {
                    fc = new Forma_Consultas(nmbre, ids, ide, ida, nmbref);
                    fc.MdiParent = this;
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCInv.Visible = true;
                    fc.Show();
                    isopen = true;
                }
            }
            catch { }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isopenv & !isopen)
                {
                    vf.Close();
                    isopenv = false;
                    fc = new Forma_Consultas(nmbre, ids, ide, ida, nmbref);
                    fc.MdiParent = this;
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = true; fc.groupCProv.Visible = false; fc.groupCInv.Visible = false;
                    fc.Show();
                    isopen = true;
                }
                else if (isopen)
                {
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = true; fc.groupCProv.Visible = false; fc.groupCInv.Visible = false;
                    fc.Update();
                }
                else
                {
                    fc = new Forma_Consultas(nmbre, ids, ide, ida, nmbref);
                    fc.MdiParent = this;
                    fc.groupCEmp.Visible = false; fc.groupCProd.Visible = true; fc.groupCProv.Visible = false; fc.groupCInv.Visible = false;
                    fc.Show();
                    isopen = true;
                }
            }
            catch { }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Forma_Consultas);
            if (frm == null)
                isopen = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (isopen & !isopenv)
            {
                fc.Close();
                isopen = false;
                //nombre, idsucursal, idempleado, idalmacen, nombrefar
                vf = new Ventas(nmbre, ids, ide, ida, nmbref);
                vf.MdiParent = this;
                vf.Show();
                isopenv = true;
            }
            else if (isopenv)
            {
                vf.Update();
            }
            else
            {
                vf = new Ventas(nmbre, ids, ide, ida, nmbref);
                vf.MdiParent = this;
                vf.Show();
                isopenv = true;
            }
        }

        private void Vendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
