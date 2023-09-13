using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog: Animal
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Bau...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating dry dog food...");
        }
    }
}
