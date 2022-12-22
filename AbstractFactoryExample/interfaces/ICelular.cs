using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.interfaces
{
    //AbstractFatory
    public interface ICelular
    {
        ISmartPhone BuscarSmartPhone();

        INormalPhone BuscarNormalPhone();
    }
}
