using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor_Numerico
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BotonBinario_Click(object sender, EventArgs e)
        {
            if (this.OnScreen.Controls.Count > 0)
                this.OnScreen.Controls.RemoveAt(0);
            OrigenBinario vista = new OrigenBinario();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.OnScreen.Controls.Add(vista);
            this.OnScreen.Tag = vista;
            vista.Show();
        }

        private void BotonDecimal_Click(object sender, EventArgs e)
        {
            if (this.OnScreen.Controls.Count > 0)
                this.OnScreen.Controls.RemoveAt(0);
            OrigenDecimal vista = new OrigenDecimal();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.OnScreen.Controls.Add(vista);
            this.OnScreen.Tag = vista;
            vista.Show();
        }

        private void BotonHex_Click(object sender, EventArgs e)
        {
            if (this.OnScreen.Controls.Count > 0)
                this.OnScreen.Controls.RemoveAt(0);
            OrigenHex vista = new OrigenHex();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.OnScreen.Controls.Add(vista);
            this.OnScreen.Tag = vista;
            vista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
