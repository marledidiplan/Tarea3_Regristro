using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegristroArticulos.Entidades;
using RegristroArticulos.UI.Regristro;

namespace RegristroArticulos
{
    public partial class RegristroArticulos : Form
    {
        public RegristroArticulos()
        {
            InitializeComponent();
        }

        private void RegristroArticulos_Load(object sender, EventArgs e)
        {

        }

        private void articulosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegristroA regristroA = new RegristroA();
            regristroA.Show();

        }
    }
}
