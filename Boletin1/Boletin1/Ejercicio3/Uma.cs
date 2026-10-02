using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Uma : IComparable<Uma>
    {

        private string _nombre;
        private int _rareza;
        private string _equipo;
        private string _rutaImagen;

        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Rareza
        {
            get { return this._rareza; }
        }

        public string Equipo
        {
            get { return this._equipo; }
        }

        public string RutaImagen
        {
            get { return this._rutaImagen; }
        }

        public Uma(string nombre, int rareza, string equipo, string rutaImagen)
        {
            this._nombre = nombre;
            this._rareza = rareza;
            this._equipo = equipo;
            this._rutaImagen = rutaImagen;
        }

        public int CompareTo(Uma otraUma)
        {
            return this.Rareza.CompareTo(otraUma.Rareza);
        }
    }
}