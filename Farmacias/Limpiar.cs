using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacias
{
    class Limpiar
    {
        Forma_X f1x;
        Ventas V;
        public Limpiar(Forma_X fx)
        {
            f1x = fx;
        }
        public Limpiar(Ventas v)
        {
            V = v;
        }
        #region Forma_X
        public void Clean_EdProv()
        {
            f1x.tbxEdPResp.Clear();
            f1x.tbxEdPNom.Clear();
            f1x.tbxEdPNu.Clear();
            f1x.tbxEdPDir.Clear();
            f1x.tbxEdPRFC.Clear();
            f1x.tbxEdPTel.Clear();
            f1x.tbxEdPCorr.Clear();
        }
        public void Clean_AddProv()
        {
            f1x.tbxAddPCorr.Clear();
            f1x.tbxAddPDir.Clear();
            f1x.tbxAddPNom.Clear();
            f1x.tbxAddPResp.Clear();
            f1x.tbxAddPRFC.Clear();
            f1x.tbxAddPTel.Clear();
        }
        public void Clean_AddProd()
        {
            f1x.cbxAddPdRec.Text = "";
            f1x.cbxAddPdVia.Text = "";
            f1x.tbxAddPdAct.Clear();
            f1x.tbxAddPdNom.Clear();
            f1x.tbxAddPdNumProv.Clear();
            f1x.tbxAddPdPrec.Clear();
        }
        public void Clean_EddProd()
        {
            f1x.tbxEdPdNum.Clear();
            f1x.cbxEdPdRec.Text = "";
            f1x.cbxEdPdVia.Text = "";
            f1x.tbxEdPdAct.Clear();
            f1x.tbxEdPdNom.Clear();
            f1x.tbxEdPdNumProv.Clear();
            f1x.tbxEdPdPrec.Clear();
        }
        public void Clean_AddInv()
        {
            f1x.tbxAddInvNP.Clear();
            f1x.tbxAddInvQt.Clear();
            f1x.tbxAddInvCom.Clear();
        }

        public void Clean_EdInv()
        {
            f1x.tbxEdInvNP.Clear();
            f1x.tbxEdInvQt.Clear();
            f1x.tbxEdInvCom.Clear();
        }
        public void Clean_AddEmp()
        {
            f1x.tbxAddENom.Clear();
            f1x.tbxAddEApe.Clear();
            f1x.cbxAddEPues.Text = "";
            f1x.cbxAddEStat.Text = "";
            f1x.tbxAddEUsua.Clear();
            f1x.tbxAddECont.Clear();
        }
        public void Clean_EdEmp()
        {
            f1x.tbxEdENom.Clear();
            f1x.tbxEdEApe.Clear();
            f1x.cbxEdEPues.Text = "";
            f1x.cbxEdEStat.Text = "";
            f1x.tbxEdEUsua.Clear();
            f1x.tbxEdECont.Clear();
            f1x.tbxEdENum.Clear();
        }
        #endregion
        #region Ventas
        public void Facturas()
        {
            V.txtCP.Clear();
            V.txtIP.Clear();
            V.txtNP.Clear();
            V.lblP.Text = "";
            V.lblT.Text = "";
            V.dgVenta.Rows.Clear();//Elimina las filas
            V.txtIP.Focus();//para que devuelva el foco
        }
        public void cancelar()
        {
            if (f1x.groupAddEmp.Visible)
            {
                f1x.tbxAddENom.Clear();
                f1x.cbxAddEPues.Text = "";
                f1x.tbxAddEApe.Clear();
                f1x.cbxAddEStat.Text = "";
                f1x.cbxAddEPues.Text = "";
                f1x.tbxAddEUsua.Clear();
                f1x.tbxAddECont.Clear();
                f1x.tbxAddENom.Focus();
            }
            else if (f1x.groupEditEmp.Visible)
            {
                f1x.tbxEdENum.Clear();
                f1x.tbxEdENom.Clear();
                f1x.cbxEdEPues.Text = "";
                f1x.tbxEdEApe.Clear();
                f1x.cbxEdEStat.Text = "";
                f1x.cbxEdEPues.Text = "";
                f1x.tbxEdEUsua.Clear();
                f1x.tbxEdECont.Clear();
                f1x.tbxEdENum.Focus();
            }
            else if (f1x.groupAddInventario.Visible)
            {
                f1x.tbxAddInvNP.Clear();
                f1x.tbxAddInvQt.Clear();
                f1x.tbxAddInvCom.Clear();
                f1x.tbxAddInvNP.Focus();
            }
            else if (f1x.groupEditInv.Visible)
            {
                f1x.tbxEdInvNP.Clear();
                f1x.tbxEdInvQt.Clear();
                f1x.tbxEdInvCom.Clear();
                f1x.tbxAddInvNP.Focus();
            }
            else if (f1x.groupAddProd.Visible)
            {
                f1x.tbxAddPdNom.Clear();
                f1x.tbxAddPdAct.Clear();
                f1x.cbxAddPdVia.Text = "";
                f1x.cbxAddPdRec.Text = "";
                f1x.tbxAddPdPrec.Clear();
                f1x.tbxAddPdNumProv.Clear();
                f1x.tbxAddPdNom.Focus();
            }
            else if (f1x.groupEditProd.Visible)
            {
                f1x.tbxEdPdNum.Clear();
                f1x.tbxEdPdNom.Clear();
                f1x.tbxEdPdAct.Clear();
                f1x.cbxEdPdVia.Text = "";
                f1x.cbxEdPdRec.Text = "";
                f1x.tbxEdPdPrec.Clear();
                f1x.tbxEdPdNumProv.Clear();
                f1x.tbxEdPdNum.Focus();
            }
            else if (f1x.groupAddProv.Visible)
            {
                f1x.tbxAddPNom.Clear();
                f1x.tbxAddPResp.Clear();
                f1x.tbxAddPDir.Clear();
                f1x.tbxAddPRFC.Clear();
                f1x.tbxAddPTel.Clear();
                f1x.tbxAddPCorr.Clear();
                f1x.tbxAddPNom.Focus();
            }
            else if (f1x.groupEditProv.Visible)
            {
                f1x.tbxEdPNu.Clear();
                f1x.tbxEdPNom.Clear();
                f1x.tbxEdPResp.Clear();
                f1x.tbxEdPDir.Clear();
                f1x.tbxEdPRFC.Clear();
                f1x.tbxEdPTel.Clear();
                f1x.tbxEdPCorr.Clear();
                f1x.tbxEdPNu.Focus();
            }
        }
        #endregion
    }
}
