using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    internal class Disco
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        public TipoEdicion Edicion { get; set; }
    }
}
