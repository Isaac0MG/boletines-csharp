using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    internal class Cometa : Astro, ITerraformable
    {
        public bool esHabitable()
        {
            return false;
        }
    }
}
