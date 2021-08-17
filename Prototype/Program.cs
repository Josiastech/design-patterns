using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal()
            {
                Nombre = "Oveja Dolly",
                Patas = 4
            };

            Animal oAnimalClonado = oAnimal;
            oAnimalClonado.Patas = 5;

            Console.WriteLine("Hello World!");
        }
    }
}
