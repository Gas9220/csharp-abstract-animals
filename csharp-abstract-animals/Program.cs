using csharp_abstract_animals.Class;
using csharp_abstract_animals.Interface;

// Class test
Console.WriteLine("Dog test");
Dog dog = new Dog();
dog.Sleep();
dog.AnimalNoise();
dog.Eat();

Console.WriteLine();

Console.WriteLine("Sparrow test");
Sparrow sparrow = new Sparrow();
sparrow.Sleep();
sparrow.AnimalNoise();
sparrow.Eat();

Console.WriteLine();

Console.WriteLine("Eagle test");
Eagle eagle = new Eagle();
eagle.Sleep();
eagle.AnimalNoise();
eagle.Eat();

Console.WriteLine();

Console.WriteLine("Dolphin test");
Dolphin dolphin = new Dolphin();
dolphin.Sleep();
dolphin.AnimalNoise();
dolphin.Eat();

Console.WriteLine();

// Interface test
void makeFly(IFly flyingAnimal)
{
    flyingAnimal.Fly();
}

void makeSwim(ISwim swimAnimal)
{
    swimAnimal.Swim();
}

makeFly(eagle);
makeSwim(dolphin);
