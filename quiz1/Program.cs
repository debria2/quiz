using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1 
{
    internal class dados
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


    

