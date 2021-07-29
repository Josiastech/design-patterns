using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instace.mensaje);
            Singleton.Instace.mensaje = "Hola marte";
            Console.WriteLine(Singleton.Instace.mensaje);
        }
    }
}
