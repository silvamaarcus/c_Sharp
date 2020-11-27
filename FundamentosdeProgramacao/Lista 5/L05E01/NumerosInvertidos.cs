using System;
using System.Collections.Generic;
using System.Text;

namespace L05E01
{
    class NumerosInvertidos
    {
        public string Numeros;

        public string Inversao()
        {
            string numeroResult = ""; 

            for (int i = Numeros.Length; i > 0; i--)
            {
                numeroResult += i;
            }
            return numeroResult;
        }
    }
}
