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
    public partial class Gerente : Form
    {
        public string nomb, idsuc, idemp, idal,nomfar;
        Forma_X fx;
        Forma_Consultas fc;
        GerenteVentas gv;

        bool isopen, cisopen, cisopen1;
        public Gerente(string a,string b, string c, string d,string e)
        {
            nomb = a; idsuc = b; idemp = c; idal = d; nomfar = e;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /*******************************/
        /*******************************/
        /*******************************/
        #region empleados
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "emad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                isopen = true;
            }
            else
            {
                fx.state = "emad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = true;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
            }
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "emed";

                fx.groupAddEmp.Visible = false; fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = true;

                fx.Show();
                isopen = true;
            }
            else
            {
                fx.state = "emed";

                fx.groupAddEmp.Visible = false; fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = true;

                fx.Update();
            }
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Forma_X);
            if (frm == null)
            { isopen = false; }
        }
        #endregion
        /*******************************/
        /*******************************/
        /*******************************/

        #region Inventario

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//*
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "invad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddEmp.Visible = false;fx.groupAddInventario.Visible = true;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "invad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = true; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {//****
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "inved";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = true; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "inved";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = true; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }

        }
        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Forma_X);
            if (frm == null)
            { isopen = false; }

        }
        #endregion
        /*******************************/
        /*******************************/
        /*******************************/

        #region Productos
        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Forma_X);
            if (frm == null)
            { isopen = false; }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "pdad";
                

                fx.groupAddProd.Visible = true; fx.groupAddProv.Visible = false; fx.groupAddEmp.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "pdad";

                fx.groupAddProd.Visible = true; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "pded";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddEmp.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = true; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "pded";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = true; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }
        }
        #endregion
        #region Proveedores
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Forma_X);
            if (frm == null)
            { isopen = false; }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "pvad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = true; fx.groupAddEmp.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "pvad";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = true; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = false; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isopen)
            {
                fx = new Forma_X(nomb, idsuc, idemp, idal, nomfar);
                fx.MdiParent = this;
                fx.state = "pved";

                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddEmp.Visible = false; fx.groupAddInventario.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = true; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Show();
                fx.Focus();
                isopen = true;
            }
            else
            {
                fx.state = "pved";
                fx.groupAddProd.Visible = false; fx.groupAddProv.Visible = false; fx.groupAddInventario.Visible = false; fx.groupAddEmp.Visible = false;
                fx.groupEditProd.Visible = false; fx.groupEditProv.Visible = true; fx.groupEditInv.Visible = false; fx.groupEditEmp.Visible = false;

                fx.Update();
                fx.Focus();
            }
        }
        #endregion

        #region Consultas
        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            Form cf = this.MdiChildren.FirstOrDefault(x => x is Forma_Consultas);
            if (cf == null)
                cisopen = false;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cisopen)
            {
                fc = new Forma_Consultas(nomb, idsuc, idemp, idal, nomfar);
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false;
                fc.MdiParent = this;
                fc.Show();
                fc.Focus();
                cisopen = true;
            }
            else
            {
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCEmp.Visible = true;
                fc.Update();
                fc.Focus();
            }
        }

        private void inventarioDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cisopen)
            {
                fc = new Forma_Consultas(nomb, idsuc, idemp, idal, nomfar);
                fc.groupCInv.Visible = true; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCEmp.Visible = false;
                fc.MdiParent = this;
                fc.Show();
                fc.Focus();
                cisopen = true;
            }
            else
            {
                fc.groupCInv.Visible = true; fc.groupCProd.Visible = false; fc.groupCProv.Visible = false; fc.groupCEmp.Visible = false;
                fc.Update();
                fc.Focus();
            }

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cisopen)
            {
                fc = new Forma_Consultas(nomb, idsuc, idemp, idal, nomfar);
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = true; fc.groupCProv.Visible = false; fc.groupCEmp.Visible = false;
                fc.MdiParent = this;
                fc.Show();
                fc.Focus();
                cisopen = true;
            }
            else
            {
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = true; fc.groupCProv.Visible = false; fc.groupCEmp.Visible = false;
                fc.Update();
                fc.Focus();
            }
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!cisopen)
            {
                fc = new Forma_Consultas(nomb, idsuc, idemp, idal, nomfar);
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = true; fc.groupCEmp.Visible = false;
                fc.MdiParent = this;
                fc.Show();
                fc.Focus();
                cisopen = true;
            }
            else
            {
                fc.groupCInv.Visible = false; fc.groupCProd.Visible = false; fc.groupCProv.Visible = true; fc.groupCEmp.Visible = false;
                fc.Update();
                fc.Focus();
            }
        }
        #endregion

        private void Gerente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        #region Ventas

        private void totalesToolStripMenuItem_Click(object sender, EventArgs e)//Totales
        {            
            if (!cisopen1)
            {
                gv = new GerenteVentas(nomb, idsuc, idemp, idal, nomfar); gv.groupVF.Visible = false;
                gv.groupVT.Visible = true; gv.groupVV.Visible = false; gv.groupVF.Visible = false;
                gv.MdiParent = this;
                gv.Show();
                gv.Focus();
                cisopen = true;
            }
            else
            {
                gv.groupVT.Visible = true; gv.groupVV.Visible = false; gv.groupVF.Visible = false;
                gv.Update();
                gv.Focus();
            }
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)//Vendedor
        {
            if (!cisopen1)
            {
                gv = new GerenteVentas(nomb, idsuc, idemp, idal, nomfar);
                gv.groupVT.Visible = false; gv.groupVV.Visible = true; gv.groupVF.Visible = false;
                gv.MdiParent = this;
                gv.Show();
                gv.Focus();
                cisopen = true;
            }
            else
            {
                gv.groupVT.Visible = false; gv.groupVV.Visible = true; gv.groupVF.Visible = false;
                gv.Update();
                gv.Focus();
            }
        }

        private void ventasControladasToolStripMenuItem_Click(object sender, EventArgs e)//Controladas
        {

            if (!cisopen1)
            {
                /****Luego lo hacemos we *****/

                gv = new GerenteVentas(nomb, idsuc, idemp, idal, nomfar);
                gv.groupVT.Visible = false; gv.groupVV.Visible = false; gv.groupVF.Visible = false;//falta este grupo
                gv.MdiParent = this;
                gv.Show();
                gv.Focus();
                cisopen = true;
            }
            else
            {
                gv.groupVT.Visible = false; gv.groupVV.Visible = false; gv.groupVF.Visible = false;
                gv.Update();
                gv.Focus();
            }
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!cisopen1)
            {
                gv = new GerenteVentas(nomb, idsuc, idemp, idal, nomfar);
                gv.groupVT.Visible = false; gv.groupVV.Visible = false; gv.groupVF.Visible = true;
                gv.MdiParent = this;
                gv.Show();
                gv.Focus();
                cisopen = true;
            }
            else
            {
                gv.groupVT.Visible = false; gv.groupVV.Visible = false; gv.groupVF.Visible = true;
                gv.Update();
                gv.Focus();
            }
        }
        #endregion
    }
}
