using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EjercicioPOO
{
    internal abstract class Astro
    {
        private string _nombre;

        public string Nombre
        {
            set
            {
                this._nombre = value.ToUpper();
            }
            get
            {
                return String.Format("\"{0}\"", this._nombre);
            }
        }
        private double _radio;

        public double Radio
        {
            set
            {
                if (value < 0)
                {
                    this._radio = 0;
                    throw new RadioException("El radio tiene que ser un número positivo.");
                }
                else
                {
                    this._radio = value;
                }
            }
            get
            {
                return this._radio;
            }
        }

        public Astro(string nombre, double radio)
        {
            this.Nombre = nombre;
            this.Radio = radio;
        }

        public Astro() : this("Tierra", 6378) { }

        public override bool Equals(object? obj)
        {
            if (obj is Astro)
            {
                return this.Nombre == ((Astro)obj).Nombre;
            }
            else if (obj is String)
            {
                return this._nombre == (String)obj;
            }
            else
            {
                return false;
            }
        }
    }
}
