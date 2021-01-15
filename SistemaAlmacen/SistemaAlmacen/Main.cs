using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rECIBOALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboAlmacen reciboalmacen = new ReciboAlmacen();
            reciboalmacen.ShowDialog();
        }

        private void eMBARQUEALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmbarqueAlmacen embarquealmacen = new EmbarqueAlmacen();
            embarquealmacen.ShowDialog();
        }

        private void iNVENTARIOALMACENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioAlmacen inventarioalmacen = new InventarioAlmacen();
            inventarioalmacen.ShowDialog();
        }
    }
}
