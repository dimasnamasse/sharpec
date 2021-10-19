using System;

namespace _3
{
    interface IAnimals
    {

        const int minSpeed = 0;
        static int maxSpeed = 20;
        static string Wool = "Yes";
        static int limbs = 4;
        static int tail = 1;
        void DoSound();
    }
    class  Cat:IAnimals
    {
        public void DoSound() {
            Console.WriteLine("Meow Meow");
        }
    }
    class Tiger : IAnimals
    {
        public void DoSound() {
            Console.WriteLine("RRrrrrr");
        }
    }
    class Dog : IAnimals
    {
        public void DoSound() {
            Console.WriteLine("Gav Gav");
        }
    }
    class Program
        {

        static void Sounds(IAnimals animal)
        {
            animal.DoSound();
        }
        static void Main(string[] args)
            {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Tiger tiger = new Tiger();
            Sounds(dog);
            Sounds(cat);
            Sounds(tiger);

        }
        }
    }
        