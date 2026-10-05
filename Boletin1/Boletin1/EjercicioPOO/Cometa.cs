using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    internal class Cometa : Astro, ITerraformable
    {
        public Cometa(string nombre, double radio) : base(nombre, radio)
        {

        }

        public Cometa() { }

        public bool esHabitable()
        {
            return false;
        }
    }
}
