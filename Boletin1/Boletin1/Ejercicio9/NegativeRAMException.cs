using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    internal class NegativeRAMException : ArgumentException
    {
        public NegativeRAMException(string mensaje) : base(mensaje) { }
    }
}
