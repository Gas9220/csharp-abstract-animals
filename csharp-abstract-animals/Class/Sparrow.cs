using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Class
{
    internal class Sparrow : Animal, IFly
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Cip cip...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating worms...");
        }

        public void Fly()
        {
            Console.WriteLine("I'm a sparrow and i'm flying");
        }
    }
}
