using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    internal class dados
    {
        public static int acerto;
        public static int erro;
        public static void Acertou()
        {
            acerto++;
        }
        public static  void Errou()
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
