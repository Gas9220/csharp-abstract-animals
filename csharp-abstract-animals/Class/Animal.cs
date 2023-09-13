using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Class
{
    internal abstract class Animal
    {
        public void Sleep()
        {
            Console.WriteLine("Zzzzz....");
        }

        public abstract void AnimalNoise();

        public abstract void Eat();
    }
}
