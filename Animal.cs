﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAMENPARCIAL
{
    public class Animal
    {
        string nombre;
        string especie;
        string alimentación;
        int tiempovida;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Alimentación { get => alimentación; set => alimentación = value; }
        public int Tiempovida { get => tiempovida; set => tiempovida = value; }
    }
}