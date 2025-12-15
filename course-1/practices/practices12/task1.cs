using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "Шарик";
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Name = "Шарик";
            cat.Eat();
            cat.Meow();

        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Животное ест.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Собака лает");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Кошка мяукает");
        }
    }
}
