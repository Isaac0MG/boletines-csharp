using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    internal class RadioException : ArgumentException
    {
        public RadioException(string mensaje) : base(mensaje) { }
    }
}
