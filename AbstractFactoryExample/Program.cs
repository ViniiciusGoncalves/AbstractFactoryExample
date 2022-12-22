using AbstractFactoryExample.ConcretesFactory;
using AbstractFactoryExample.interfaces;
using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICelular nokiaCelular = new Nokia();
            CelularClient nokiaClient = new CelularClient(nokiaCelular);

            Console.WriteLine("*------------- NOKIA ------------- *");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhes());

            ICelular iphoneCelular = new Iphone();
            CelularClient iphoneClient = new CelularClient(iphoneCelular);

            Console.WriteLine("*------------- IPHONE ------------- *");
            Console.WriteLine(iphoneClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(iphoneClient.BuscarNormalPhoneModeloDetalhes());

            Console.ReadKey();
        }
    }
}
