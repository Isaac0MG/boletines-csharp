using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_Tema4
{
    internal class TagImagen
    {
        private int indiceInterno;
        private string nombreImagen;

        private long tamanioBytes;

        public TagImagen(int indice, string ruta, long tamanioBytes)
        {
            this.indiceInterno = indice;
            this.nombreImagen = ruta;
            this.tamanioBytes = tamanioBytes;
        }

        public int GetIndiceInterno()
        {
            return this.indiceInterno;
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
