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
    public partial class OrigenBinario : Form
    {
        public OrigenBinario()
        {
            InitializeComponent();
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void Traducir_Click(object sender, EventArgs e)
        {
            Traductor traducir = new Traductor();
            
            Resultado_decimal.Text = Convert.ToString(traducir.Bin_Dec(Input.Text));
            Resultado_Hexadecimal.Text = traducir.Dec_Hex(Convert.ToString(traducir.Bin_Dec(Input.Text)));
        }

        private void Traduccion_Decimal_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
