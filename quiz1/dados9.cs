﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz9
{
    internal class dados9
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
