using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia Pixel\nRam: 3GB\nCamera: 8MP\n";
        }
    }
}
