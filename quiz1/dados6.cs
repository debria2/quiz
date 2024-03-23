using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz6
{
    internal class dados6
    {
        public static int erro = 0;
        public static int acerto = 0;

        public void acertou()
        {
            acerto++;
        }

        public void errou()
        {
            erro++;
        }

        public static int mostrarErros()
        {
            return erro;
        }
        public int mostrarAcertos()
        {
            return acerto;
        }
    }
}
