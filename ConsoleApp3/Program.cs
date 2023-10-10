using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal sheep = new Sheep();
            Animal cow = new Cow();
            Animal cheeta = new Cheeta();
            Animal Monkey = new Monkey();
            Animal Crocodile = new Crocodile();

            Console.WriteLine("Please enter your ideal animal (Dog,Cat,Sheep,Cow,Cheeta,Monkey,Crocodile)");
            string classname = Console.ReadLine();

            Console.WriteLine("results:");
            Console.WriteLine("----------");

            if (classname == "dog")
            {

                Console.WriteLine($"Kind: {dog.Species}");
                dog.Specie();
                dog.Sound();
                dog.Sleep();
                dog.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "cat")
            {
                Console.WriteLine($"kind: {cat.Species}");
                cat.Specie();
                cat.Sound();
                cat.Sleep();
                cat.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "sheep")
            {

                Console.WriteLine($"kind: {sheep.Species}");
                sheep.Specie();
                sheep.Sound();
                sheep.Sleep();
                sheep.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "cow")
            {
                Console.WriteLine($"kind: {cow.Species}");
                cow.Specie();
                cow.Sound();
                cow.Sleep();
                cow.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "crocodile")
            {
                Console.WriteLine($"kind: {Crocodile.Species}");
                Crocodile.Specie();
                Crocodile.Sound();
                Crocodile.Sleep();
                Crocodile.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "cheeta")
            {

                Console.WriteLine($"kind: {cheeta.Species}");
                cheeta.Specie();
                cheeta.Sound();
                cheeta.Sleep();
                cheeta.Speed();
                Console.WriteLine("----------");
            }
            else if (classname == "monkey")
            {

                Console.WriteLine($"kind: {Monkey.Species}");
                Monkey.Specie();
                Monkey.Sound();
                Monkey.Sleep();
                Monkey.Speed();
                Console.WriteLine("----------");
            }
            else
            {
                Console.WriteLine("your ideal animal is not on the list :(");
                Console.WriteLine("----------");
            }

            Console.ReadLine();

        }

        abstract class Animal
        {
            public abstract string Species { get; }
            public abstract void Sound();
            public abstract void Sleep();
            public abstract void Speed();
            public abstract void Specie();
        }

        class Dog : Animal
        {
            public override string Species => "dog";

            public override void Sound()
            {
                Console.WriteLine("it says wof wof");
            }
            public override void Sleep()
            {
                Console.WriteLine("can sleeps up to 14 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("it also runs 48 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }
        }

        class Cat : Animal
        {
            public override string Species => "cat";

            public override void Sound()
            {
                Console.WriteLine("it says Meow");
            }
            public override void Sleep()
            {
                Console.WriteLine("sleeps 12 to 18 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("just like dogs it runs 48 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }
        }


        class Sheep : Animal
        {
            public override string Species => "sheep";

            public override void Sound()
            {
                Console.WriteLine("it says be be");
            }
            public override void Sleep()
            {
                Console.WriteLine("sleeps around 4 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("runs 15 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }
        }


        class Cow : Animal
        {
            public override string Species => "cow";

            public override void Sound()
            {
                Console.WriteLine("cow says mo mo");
            }
            public override void Sleep()
            {
                Console.WriteLine("they sleep 4 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("their speed is like womans. 10 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }
        }

        class Cheeta : Animal
        {
            public override string Species => "cheeta";

            public override void Sound()
            {
                Console.WriteLine("they Meow Meow like cats coz they are in a same branch");
            }
            public override void Sleep()
            {
                Console.WriteLine("they sleeps up to 18 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("they are the fastest animal in the entire world with max speed of 130 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }
        }
        class Monkey : Animal
        {
            public override string Species => "monkey";

            public override void Sound()
            {
                Console.WriteLine("they make unconventional sounds");
            }
            public override void Sleep()
            {
                Console.WriteLine("base on their similarity to modern day humans they sleep 12 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("it also runs 21 km/h. for a human its between 8 and 12 km/h.");
            }
            public override void Specie()
            {
                Console.WriteLine("mammal");
            }

        }
        class Crocodile : Animal
        {
            public override string Species => "crocodile";

            public override void Sound()
            {
                Console.WriteLine("base on my researches it doesnt have an actual sound");
            }
            public override void Sleep()
            {
                Console.WriteLine("they sleep 17 hours a day");
            }
            public override void Speed()
            {
                Console.WriteLine("they run 30 km/h");
            }
            public override void Specie()
            {
                Console.WriteLine("reptail");
            }

        }
    }
}






