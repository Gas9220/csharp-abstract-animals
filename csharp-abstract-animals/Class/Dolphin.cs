using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Class
{
    internal class Dolphin : Animal, ISwim
    {
        public override void AnimalNoise()
        {
            Console.WriteLine("Dolphin sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some fish");
        }

        public void Swim()
        {
            Console.WriteLine("I'm a dolphin and i'm swimming");
        }
    }
}
