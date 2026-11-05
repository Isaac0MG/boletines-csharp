using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Tema4
{
    internal class TagImagen
    {
        private int indice;
        private string nombreImagen;

        private long tamanioBytes;

        public TagImagen(int indice, string ruta, long tamanioBytes)
        {
            this.indice = indice;
            this.nombreImagen = ruta;
            this.tamanioBytes = tamanioBytes;
        }

        public int GetIndice()
        {
            return this.indice;
        }

        public string GetNombreImagen()
        {
            return this.nombreImagen;
        }

        public long getTamanioBytes()
        {
            return this.tamanioBytes;
        }
    }
}
