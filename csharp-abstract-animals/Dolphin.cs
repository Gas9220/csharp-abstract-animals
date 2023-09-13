using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Dolphin sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some fish");
        }
    }
}
