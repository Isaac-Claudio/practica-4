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
    public partial class OrigenHex : Form
    {
        public OrigenHex()
        {
            InitializeComponent();
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b0123456789abcdef".Contains(e.KeyChar));
        }

        private void Traducir_Click(object sender, EventArgs e)
        {
            Traductor traducir = new Traductor();
            Resultado_decimal.Text = Convert.ToString(traducir.Hex_Dec(Input.Text));
            Resultado_Binario.Text = traducir.Dec_Bin(Convert.ToString(traducir.Hex_Dec(Input.Text)));

        }
    }
}
