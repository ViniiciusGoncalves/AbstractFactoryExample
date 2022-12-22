using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia 1600\nRam: NA\nCamera: NA\n";
        }
    }
}
