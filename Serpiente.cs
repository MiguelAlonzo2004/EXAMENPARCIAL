using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAMENPARCIAL
{
    public class Serpiente : Animal
    {
        string venenosaono;
        int longitud;

        public string Venenosaono { get => venenosaono; set => venenosaono = value; }
        public int Longitud { get => longitud; set => longitud = value; }
    }
}