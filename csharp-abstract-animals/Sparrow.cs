using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Sparrow : Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Cip cip...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating worms...");
        }
    }
}
