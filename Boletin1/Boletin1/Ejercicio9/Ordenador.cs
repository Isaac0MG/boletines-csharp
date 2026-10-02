using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    internal class Ordenador
    {
        private string _nombre;

        public string Nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }
        private int _memoria;

        public int Memoria
        {
            set
            {
                if (value < 0)
                {
                    throw new NegativeRAMException("La memoria RAM no puede ser negativa.");
                }
                else
                {
                    this._memoria = value;
                }
            }
            get { return this._memoria; }
        }

        public static bool ipValida(string ip)
        {
            string[] cuartetos = ip.Split('.');

            byte n = 0;

            if (cuartetos.Length == 4)
            {
                foreach (string s in cuartetos)
                {
                    bool esByte = byte.TryParse(s, out _);

                    if (!esByte)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
