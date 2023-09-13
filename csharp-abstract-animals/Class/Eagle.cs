using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Class
{
    internal class Eagle : Animal, IFly
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Eagle sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some meat");
        }

        public void Fly()
        {
            Console.WriteLine("I'm an eagle and i'm flying");
        }
    }
}
