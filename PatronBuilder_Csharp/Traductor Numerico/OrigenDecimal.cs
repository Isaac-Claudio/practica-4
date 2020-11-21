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
    public partial class OrigenDecimal : Form
    {
        public OrigenDecimal()
        {
            InitializeComponent();
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b0123456789".Contains(e.KeyChar));
        }

        private void Traducir_Click(object sender, EventArgs e)
        {
            Traductor traducir = new Traductor();
            Resultado_Binario.Text = traducir.Dec_Bin(Input.Text);
            Resultado_Hexadecimal.Text = traducir.Dec_Hex(Input.Text);

        }

    }
}
