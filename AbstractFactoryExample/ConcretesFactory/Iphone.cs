using AbstractFactoryExample.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.ConcretesFactory
{
    public class Iphone : ICelular
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Iphone4();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new Iphone14ProMax();
        }
    }
}
