﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_03._0._03
{
    internal class Galletita
    {
        // atributos --> Como es 
        private string sabor;
        private bool tieneChip;
        int pesoEnGramos;

        public Galletita(string sabor, int pesoEngramos)
        {
            this.sabor = sabor;
            this.pesoEnGramos = pesoEngramos;
        }

        // Metodos --> Comportamientos --> Que hace o que puede hacer?  
        public string GetSabor()
        {
            return sabor;
        }
    }
}
