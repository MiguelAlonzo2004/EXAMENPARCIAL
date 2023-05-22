using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAMENPARCIAL
{
    public class Ave : Animal
    {
        string vuelaono;
        int incubación;

        public string Vuelaono { get => vuelaono; set => vuelaono = value; }
        public int Incubación { get => incubación; set => incubación = value; }
    }
}