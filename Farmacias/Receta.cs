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
    public partial class Receta : Form
    {
        Connections cx = new Connections();
        public Receta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cx.receta(textBox1.Text,textBox2.Text,textBox3.Text);
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            label2.Text = cx.NumeroReceta().ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
