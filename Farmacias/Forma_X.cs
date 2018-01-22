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
    public partial class Forma_X : Form
    {
        Connections cx = new Connections();

        public string nom, idsu, idem, ida, state, NomFarma;

        public Forma_X()
        {
            InitializeComponent();
        }

        public Forma_X(string a, string b, string c, string d,string e)
        {
            nom = a; idsu = b; idem = c; ida = d; NomFarma = e;
            InitializeComponent();
        }


        private void Forma_X_Load(object sender, EventArgs e)
        {
            labelNomFarma.Text = NomFarma;
            Empleado.Text = nom;
            cx = new Connections(this);
            cx.cbx();
            timer1.Start();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Hora.Text = DateTime.Now.ToLongTimeString();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.Focused)
                return base.ProcessCmdKey(ref msg, keyData);
            if ((keyData != Keys.F1) & (keyData != Keys.F2) & (keyData != Keys.F3) & (keyData != Keys.F4) & (keyData != Keys.F5))
                return base.ProcessCmdKey(ref msg, keyData);
            switch (keyData)
            {
                case Keys.F1:
                    #region proveedores
                if (state == "pvad")
                {
                    cx.insertarProv(tbxAddPNom.Text,tbxAddPResp.Text,tbxAddPDir.Text,tbxAddPRFC.Text,tbxAddPTel.Text,tbxAddPCorr.Text);
                    MessageBox.Show("Guardado!");
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_AddProv();
                    //idproveedor, Nombre, Responsable, Direccion, RFC, Telefono, Correo     
                    //insert into proveedor(nombre,responsable,direccion,rfc,telefono,correo) values('Bayer','Mauricio Lizarraga','Paseo de los heores','12as45ad664a1','6645604723','mlizarraga@bayer.com')
                }
                if (state == "pved")
                {
                    cx.UpdateProv(tbxEdPNom.Text, tbxEdPResp.Text, tbxEdPDir.Text, tbxEdPRFC.Text, tbxEdPTel.Text, tbxEdPCorr.Text, tbxEdPNu.Text);
                    MessageBox.Show("Guardado!");
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_EdProv();
                }
                #endregion 
                #region productos
                if (state == "pdad")
                {
                    //idproducto, producto, Activo, idvia, reqReceta, Precio, idproveedor            
                    cx.insertarProd(tbxAddPdNom.Text, tbxAddPdAct.Text, cbxAddPdVia.Text.Substring(0, 1), cbxAddPdRec.Text.Substring(0, 1), tbxAddPdPrec.Text, tbxAddPdNumProv.Text);
                    MessageBox.Show("Guardado!");
                    cx = new Connections(this);
                    cx.cbx();
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_AddProd();
                }
                if (state == "pded")
                {
                    cx.UpdateProd(tbxEdPdNom.Text, tbxEdPdAct.Text, cbxEdPdVia.Text.Substring(0, 1), cbxEdPdRec.Text.Substring(0, 1), tbxEdPdPrec.Text, tbxEdPdNumProv.Text, tbxEdPdNum.Text);
                    MessageBox.Show("Guardado!");
                    cx = new Connections(this);
                    cx.cbx();
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_EddProd();
                }
                #endregion
                #region inventarios
                if (state == "invad")
                {
                    //existencias, idalmacen, idproducto, fecha, comentarios          
                    cx.insertarInv(tbxAddInvQt.Text, tbxAddInvNP.Text, tbxAddInvCom.Text,ida);
                    MessageBox.Show("Guardado!");
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_AddInv();
                }
                if (state == "inved")
                {
                    //existencias, idalmacen, idproducto, fecha, comentarios  
                    cx.UpdateInv(tbxEdInvQt.Text, tbxEdInvNP.Text, tbxEdInvCom.Text,ida);
                    MessageBox.Show("Guardado!");
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_EdInv();
                }
                #endregion
                #region empleados
                if (state == "emad")
                {
                    //idempleado, nombre, apellidos, idpuesto, idsucursal, estado
                    //idusuario, usuario, contraseña
                    cx.insertarEmp(tbxAddENom.Text, tbxAddEApe.Text, cbxAddEPues.Text.Substring(0, 1),idsu,cbxAddEStat.Text.Substring(0, 1),tbxAddEUsua.Text,tbxAddECont.Text);
                    MessageBox.Show("Guardado!");
                    cx = new Connections(this);
                    cx.cbx();
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_AddEmp();
                }
                if (state == "emed")
                {
                    //idempleado, nombre, apellidos, idpuesto, idsucursal, estado
                    cx.UpdateEmp(tbxEdENom.Text,tbxEdEApe.Text, cbxEdEPues.Text.Substring(0, 1), idsu, cbxEdEStat.Text.Substring(0, 1), tbxEdEUsua.Text, tbxEdECont.Text,tbxEdENum.Text);
                    MessageBox.Show("Guardado!");
                    cx = new Connections(this);
                    cx.cbx();
                    Limpiar limp = new Limpiar(this);
                    limp.Clean_EdEmp();
                }
                #endregion
                    break;
                case Keys.F2:
                    //limpiar la pantalla no mas :D
                    Limpiar l = new Limpiar(this);
                    l.cancelar();
                    break;
                case Keys.F3:
                    Close();
                    break;
                default:
                    break;
            }
            return true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            cx = new Connections(this);
            cx.busquedaEdProd(tbxEdPdNum.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cx = new Connections(this);
            cx.busquedaEdInv(tbxEdInvNP.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cx = new Connections(this);
            cx.busquedaEdEmp(tbxEdENum.Text);
        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            cx = new Connections(this);
            cx.busquedaEdProv(tbxEdPNu.Text);
        }

    }
}
