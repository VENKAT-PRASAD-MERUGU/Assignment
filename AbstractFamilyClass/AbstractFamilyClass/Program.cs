using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattren
{
    public class Program
    {
        public abstract class Animal
        {
            public abstract string Speak();
        }
        public class Cow : Animal
        {
            public override string Speak()
            {
                return "moo!";
            }
        }


        public class Dog : Animal
        {
            public override string Speak()
            {
                return "barking!";
            }
        }


        public class Cat : Animal
        {
            public override string Speak()
            {
                return "Meow!";
            }
        }

        public class AnimalFactory
        {
            public Animal CreateAnimal(string type)
            {
                switch (type)
                {
                    case "cow":
                        return new Cow();
                    case "dog":
                        return new Dog();
                    case "cat":
                        return new Cat();
                    default:
                        throw new ArgumentException("Invalid animal type.");
                }
            }
        }


        static void Main(string[] args)
        {

 
            AnimalFactory factory = new AnimalFactory();
            Animal cow = factory.CreateAnimal("cow");
            Console.WriteLine(cow.Speak());
           // -------------------------------------------------------------------
            Animal dog = factory.CreateAnimal("dog");
            Console.WriteLine(dog.Speak());
            // -------------------------------------------------------------------
            Animal cat = factory.CreateAnimal("cat");
            Console.WriteLine(cat.Speak());
            // -------------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
