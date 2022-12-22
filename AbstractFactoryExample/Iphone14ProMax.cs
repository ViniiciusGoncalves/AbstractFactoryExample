using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class Iphone14ProMax : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Iphone 14 Pro Max\nRam: 6GB\nCamera: 48MP\n";
        }
    }
}
