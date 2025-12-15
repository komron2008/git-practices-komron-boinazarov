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

            dog.Move();
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Животное ест.");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук");
        }

        public virtual void Move()
        {
            Console.WriteLine("Животное двигается");
        }

    }

    public class Dog : Animal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Собака бежит по дороге");
        }

        public override void Speak()
        {
            Console.WriteLine("Собака говорит: Гав-Гав!");
        }

        public void Bark()
        {
            Console.WriteLine("Собака лает");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Кошка говорит: Мяу!");
        }

        public void Meow()
        {
            Console.WriteLine("Кошка мяукает");
        }
    }
}
