using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPOO
{
    internal class Planeta : Astro, ITerraformable
    {
        private bool _gaseoso;

        public bool Gaseoso
        {
            set { this._gaseoso = value; }
            get { return this._gaseoso; }
        }

        private int numeroSatelites;

        public int NumeroSatelites
        {
            set
            {
                if (value < 0)
                {
                    this.numeroSatelites = 0;
                }
                else
                {
                    this.numeroSatelites = value;
                }
            }
            get
            {
                return this.numeroSatelites;
            }
        }

        public Planeta(bool Gaseoso, int numeroSatelites, string nombre, double radio) : base(nombre, radio)
        {
            this._gaseoso = Gaseoso;
            this.NumeroSatelites = numeroSatelites;
        }

        public Planeta() : base()
        {
            this._gaseoso = false;
            this.NumeroSatelites = -1;
        }

        public bool esHabitable()
        {
            return (Gaseoso == false) && (2000 < Radio && Radio < 8000);
        }

        public override string ToString()
        {
            return $"{Nombre,10}, {numeroSatelites,4}, {Radio,0:F2}";
        }

        public static Planeta operator ++(Planeta p)
        {
            p.numeroSatelites++;
            // p.NumeroSatelites = p.numeroSatelites;
            return p;
        }

        public static Planeta operator --(Planeta p)
        {
            p.numeroSatelites--;
            p.NumeroSatelites = p.numeroSatelites;
            return p;
        }
    }
}
