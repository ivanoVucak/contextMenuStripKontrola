using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desnoTb.Text = lijevoTb.Text;
        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            lijevoTb.Text = desnoTb.Text;
        }
    }
}
