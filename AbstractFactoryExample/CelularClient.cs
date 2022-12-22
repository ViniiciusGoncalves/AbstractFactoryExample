using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class CelularClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public CelularClient(ICelular celularFactoy)
        {
            smartPhone = celularFactoy.BuscarSmartPhone();
            normalPhone = celularFactoy.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }
    }
}
