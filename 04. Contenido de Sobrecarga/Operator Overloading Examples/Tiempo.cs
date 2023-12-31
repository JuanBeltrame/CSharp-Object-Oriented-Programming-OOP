﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Examples
{
    internal class Tiempo
    {
        int hora;
        int minutos;
        int segundos;
        string formato;

        public Tiempo() : this(0, 0, 0)
        {

        }

        public Tiempo(int hora, int minutos, string formato)
            : this(hora, minutos, 0)
        {
            this.formato = formato;
        }

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

    }
}
