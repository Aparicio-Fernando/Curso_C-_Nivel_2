using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcio { get; set; }
        public override string ToString()
        {
            return Descripcio;
        }
    }
}
