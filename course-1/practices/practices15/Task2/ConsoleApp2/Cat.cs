using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat : Animal
    {
        public Cat() : base("Кошка") { }
        public Cat(string name) : base(name) { }

        public void Meow()
        {
            Console.WriteLine($"{Name} пытается мяукать...");
            MakeSound();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Мяу!");
        }
    }
}
