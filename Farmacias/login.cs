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

    public partial class login : Form
    {
        Connections cx;
        public string nombre, idsucursal, idempleado, idalmacen, nombrefar;
        //empleados.nombre,empleados.idsucursal,almacen.idalmacen 
        string u, p;
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        #region design :D
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.unlock;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._lock;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //conectar a la bd
                u = textBox1.Text;
                p = textBox2.Text;
                cx = new Connections(this);
                if (cx.Login(u, p) == "1")
                {
                    Gerente g1 = new Gerente(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                    g1.Show(this);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    this.Hide();

                }
                else if (cx.Login(u, p) == "2")
                {
                    Vendedor v = new Vendedor(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                    v.Show(this);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();//vuelta el foco
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(cx.Login(u, p));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch { MessageBox.Show("Error de validacion!"); }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        #endregion
    }
}
