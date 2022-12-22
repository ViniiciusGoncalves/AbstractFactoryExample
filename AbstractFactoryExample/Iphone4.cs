using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class Iphone4 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Iphone 4\nRam: 3GB\nCamera: 6MP\n";
        }
    }
}
