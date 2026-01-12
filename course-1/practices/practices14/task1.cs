using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal cow = new Cow();

            dog.Speak();
            cat.Speak();
            cow.Speak();
        }

        
    }
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук.");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Собака говорит: Гав-гав");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Кошка говорит: Мяу-мяу");
        }
    }
    public class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Корова говорит: Му-му");
        }
    }
}
