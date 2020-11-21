using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor_Numerico
{
    public class Traductor
    {
        public int Bin_Dec(string num)
        {
            int input, ValorDecimal = 0, ValorBase = 1, Remanente;
            input = int.Parse(num);
            while (input > 0)
            {
                Remanente = input % 10;
                ValorDecimal = ValorDecimal + Remanente * ValorBase;
                input = input / 10;
                ValorBase = ValorBase * 2;
            }
            return ValorDecimal;
        }

        public int Hex_Dec(string num)
        {
            int ValorDecimal;
            ValorDecimal = Convert.ToInt32(num, 16);
            return ValorDecimal;

        }

        public string Dec_Bin(string num)
        {
            int ValorDecimal;
            string ValorBinario;
            ValorDecimal = int.Parse(num);
            ValorBinario = "";
            while (ValorDecimal >= 1)
            {
                int Remanente = ValorDecimal % 2;
                ValorBinario = Convert.ToString(Remanente) + ValorBinario;
                ValorDecimal /= 2;
            }
            return ValorBinario;
        }

        public string Dec_Hex(string num)
        {
            int ValorDecimal = int.Parse(num);
            if (ValorDecimal < 1) return "0";

            int ValorHex = ValorDecimal;
            string ResultadoHex = string.Empty;

            while (ValorDecimal > 0)
            {
                ValorHex = ValorDecimal % 16;

                if (ValorHex < 10)
                    ResultadoHex = ResultadoHex.Insert(0, Convert.ToChar(ValorHex + 48).ToString());
                else
                    ResultadoHex = ResultadoHex.Insert(0, Convert.ToChar(ValorHex + 55).ToString());

                ValorDecimal /= 16;
            }

            return ResultadoHex;
        }
    }
}